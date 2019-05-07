using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    public class EventReservation
    {
        public string ReservationTime { get; set; }
        public string ReservationDate { get; set; }
        public int EventId { get; set; }
        public string Comment { get; set; }
    }
}
