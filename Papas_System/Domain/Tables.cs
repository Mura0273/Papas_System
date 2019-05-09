using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    public class Tables
    {
        public string TableSize;
        public int TableNo;
        //public void AddTable();
        //public void DeleteTabel();

        public Tables (string tableSize, int tableNo)
        {
            TableSize = tableSize;
            TableNo = tableNo;
        }
    }
}
