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
        public int Client_id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
