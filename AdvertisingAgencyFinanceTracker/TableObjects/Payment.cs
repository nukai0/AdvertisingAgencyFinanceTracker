using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingAgencyFinanceTracker.TableObjects
{
    internal class Payment
    {
        public int Id { get; set; }
        public int Invoice_id { get; set; }
        public DateTime Date { get; set; }
        public string DateDisplay => Date.ToString("dd.MM.yyyy");
        public int Amount { get; set; }
        public string Payment_type { get; set; }
    }
}
