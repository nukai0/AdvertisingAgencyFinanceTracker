using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace AdvertisingAgencyFinanceTracker
{
    internal class AdvertisingAgencyRepository : IAdvertisingAgencyRepository
    {
        string connection;
        public AdvertisingAgencyRepository(string connection)
        {
            this.connection = connection;
        }
    }
}
