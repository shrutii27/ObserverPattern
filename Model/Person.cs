using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverPattern.Model
{
    internal class Person
    {
        private string Name;
        private List<IObserver> observers = new List<IObserver>();
        public Person(string name)
        {
            Name= name;
        }

        public void AddObserver(IObserver observer)
        // adds an observer action to the list of observers
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)//remove
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()//notify and invoke each of them
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
        public void ChangeName(string newName)
            //change name and print new name
        {
            Name = newName;
            Console.WriteLine($"Name changed to: {Name}");
            NotifyObservers();
        }
    }
}
