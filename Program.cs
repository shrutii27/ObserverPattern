using ObserverPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Shruti");

            //create Observers
            IObserver observer1 = new NameChangeObserver();
            IObserver observer2 = new NameChangeObserver();

            //register Observers
            person.AddObserver(observer1);
            person.AddObserver(observer2);

            //change
            person.ChangeName("Ritu");

            //remove
            person.RemoveObserver(observer1);

            //another change
            person.ChangeName("ABC");
        }
    }
}
