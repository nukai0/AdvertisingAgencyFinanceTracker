using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingAgencyFinanceTracker.TableObjects
{
    internal class Proposal
    {
        public int Id { get; set; }
        public Client ClientProposal { get; set; }
        public DateTime Date { get; set; }
        public string DateDisplay => Date.ToString("dd.MM.yyyy");
        public int Amount { get; set; }
    }
}
