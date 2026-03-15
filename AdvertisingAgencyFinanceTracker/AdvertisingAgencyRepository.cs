using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using AdvertisingAgencyFinanceTracker.TableObjects;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace AdvertisingAgencyFinanceTracker
{
    internal class AdvertisingAgencyRepository : IAdvertisingAgencyRepository
    {
        string connection;
        public AdvertisingAgencyRepository(string connection)
        {
            this.connection = connection;
        }

        public async Task<Account> GetAccountAsync(string login, int password)
        {
            using (var conn = new NpgsqlConnection(connection))
            {
                return await conn.QueryFirstOrDefaultAsync<Account>("SELECT * FROM account WHERE login = @Login AND password = @Password",
                    new {@Login = login, @Password = password});
            }
        }

        public async Task<bool> UpdatePasswordAsync(string login, int oldPassword, int newPassword)
        {
            using (var conn = new NpgsqlConnection(connection))
            {
                int affectedRows = await conn.ExecuteAsync("UPDATE account SET password = @NewPassword WHERE login = @Login AND password = @OldPassword", 
                    new {@Login = login, @OldPassword = oldPassword, @NewPassword = newPassword});

                if(affectedRows > 0) return true;
                else return false;
            }
        }

        public IEnumerable<Proposal> GetProposals()
        {
            using (var conn = new NpgsqlConnection(connection))
            {
                return conn.Query<Proposal, Client, Proposal>("SELECT proposal.id, proposal.date, proposal.amount, client.id, client.company_name, client.contact_person, client.phone_number FROM proposal" +
                    " JOIN client ON client.id = proposal.client_id",
                    (proposal, client) =>
                    {
                        proposal.ClientProposal = client;
                        return proposal;
                    },
                    splitOn: "id");
            }
        }

        public int GetAmountInInvoice()
        {
            using (var conn = new NpgsqlConnection(connection))
            {
                int payments = conn.QueryFirstOrDefault<int>("SELECT SUM(amount) FROM payment;");
                int expenses = conn.QueryFirstOrDefault<int>("SELECT SUM(amount) FROM expense;");

                return payments - expenses;
            }
        }
    }
}
