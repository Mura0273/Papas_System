﻿using Papas_System.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papas_System.Domain
{
    interface IMember
    {
        void Attach(IMembership m);
        void Detach(IMembership m);
        void Notify();
    }
}
