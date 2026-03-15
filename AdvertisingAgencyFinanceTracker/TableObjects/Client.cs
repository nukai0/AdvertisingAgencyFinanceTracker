using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingAgencyFinanceTracker.TableObjects
{
    internal class Client
    {
        public int Id { get; set; }
        public string Company_name { get; set; }
        public string Contact_person { get; set; }
        public string Phone_number { get; set; }
        public int Manager_id { get; set; }
    }
}
