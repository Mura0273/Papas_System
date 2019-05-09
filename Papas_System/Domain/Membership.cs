using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    public class Membership
    {
        public int MemberNo;
        public string MemberName;
        public string SubscriptionDate;
        public string EndDate;
        public string EMail;

        public Membership (int memberNo, string memberName, string subscriptionDate, string endDate, string eMail)
        {
            MemberNo = memberNo;
            MemberName = memberName;
            SubscriptionDate = subscriptionDate;
            EndDate = endDate;
            EMail = eMail;
        }
    }
}
