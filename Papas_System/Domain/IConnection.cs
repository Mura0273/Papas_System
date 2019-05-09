using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    interface IConnection
    {
        string connectionString
        {
            get;
            set;
        }
        //"Server=EALSQL1.eal.local; Database= C_DB13_2018; User Id=C_STUDENT13; Password=C_OPENDB13;";

        void Connect();
    }
}
