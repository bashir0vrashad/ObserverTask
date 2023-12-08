using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask
{
    internal interface ICashDrawer
    {
        void AddObserver(ICashDrawerObserver observer);
        void RemoveObserver(ICashDrawerObserver observer);
        void NotifyObservers();
        void AddMoney(decimal amount);
    }
}
