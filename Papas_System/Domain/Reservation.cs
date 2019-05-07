using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    public class Reservation
    {
        public string ReservationTime { get; set; }
        public string ReservationDate { get; set; }
        public int ReservationId { get; set; }
        public string CustomerName { get; set; }
        public string Comment { get; set; }

    }
}
