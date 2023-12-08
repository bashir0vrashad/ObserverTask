using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask
{
    internal class CashDrawer:ICashDrawer
    {
        private List<ICashDrawerObserver> observers = new List<ICashDrawerObserver>();
        private decimal totalAmount;

        public void AddObserver(ICashDrawerObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ICashDrawerObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(totalAmount);
            }
        }

        public void AddMoney(decimal amount)
        {
            Console.WriteLine($"Cash Drawer: Elave Edildi - {amount:C} ");
            totalAmount += amount;
            NotifyObservers();
        }
    }
}
