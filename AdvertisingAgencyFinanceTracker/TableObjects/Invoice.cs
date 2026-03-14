using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingAgencyFinanceTracker.TableObjects
{
    internal class Invoice
    {
        public int Id { get; set; }
        public int Proposal_id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
    }
}
