using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Model
{
    //define Observers
    internal class NameChangeObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Name has changed.");
        }
    }
}

