using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connection
    {
        private static string connection = @"Data Source=RAPHA\SQLEXPRESS; Initial Catalog=RaruPharmacies; Persist Security Info=true; Integrated Security=True;";

        public static string stringConnection
        {
            get { return connection; }
        }
    }
}
