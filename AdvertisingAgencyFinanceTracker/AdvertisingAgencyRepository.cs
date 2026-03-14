using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using AdvertisingAgencyFinanceTracker.TableObjects;

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
    }
}
