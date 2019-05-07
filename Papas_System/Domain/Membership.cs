using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    public class Membership
    {
        public int MemberNo { get; set; }
        public string MemberName { get; set; }
        public string SubscriptionDate { get; set; }
        public string EndDate { get; set; }
        public string EMail { get; set; }

    }
}
