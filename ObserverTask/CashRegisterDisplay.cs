using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask
{
    internal class CashRegisterDisplay: ICashDrawerObserver
    {
        public void Update(decimal totalAmount)
        {
            Console.WriteLine($"Cash Register Display: Guncellenmis deyer {totalAmount:C}");
        }
    }
}
