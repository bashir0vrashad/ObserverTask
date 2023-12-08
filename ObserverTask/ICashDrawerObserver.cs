using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask
{
    internal interface ICashDrawerObserver
    {
        void Update(decimal totalAmount);
    }
}
