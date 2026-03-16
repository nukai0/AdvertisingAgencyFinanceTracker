using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingAgencyFinanceTracker.TableObjects
{
    internal class ClientInvoice
    {
        public Client Client { get; set; }
        public Invoice Invoice { get; set; }
    }
}
