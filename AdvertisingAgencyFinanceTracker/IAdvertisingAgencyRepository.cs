using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvertisingAgencyFinanceTracker.TableObjects;

namespace AdvertisingAgencyFinanceTracker
{
    internal interface IAdvertisingAgencyRepository
    {
        Task<Account> GetAccountAsync(string login, int password);
        Task<bool> UpdatePasswordAsync(string login, int oldPassword, int newPassword);
        IEnumerable<Proposal> GetProposals();
        int GetAmountInInvoice();
    }
}
