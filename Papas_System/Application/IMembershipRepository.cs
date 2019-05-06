using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    interface IMembershipRepository
    {
        void Attach(IMember m);
        void Detach(IMember m);
        void Notify();
    }
    public test
}
