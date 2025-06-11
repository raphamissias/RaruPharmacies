using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connection
    {
        private static string connection = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=RaruPharmacies; Persist Security Info=true; User=aluno; Password=aluno123!";

        public static string stringConnection
        {
            get { return connection; }
        }
    }
}
