using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    public abstract class ObservableLightNode : LightNode
    {
        private List<ILightNodeObserver> observers = new List<ILightNodeObserver>();

        public void AddObserver(ILightNodeObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ILightNodeObserver observer)
        {
            observers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnNodeChanged(this);
            }
        }
    }
}
