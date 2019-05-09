using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papas_System.Application;

namespace Papas_System.Domain
{
    public class Membership : IMember
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

        public void Attach(IMembership m)
        {
            throw new NotImplementedException();
        }

        public void Detach(IMembership m)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
