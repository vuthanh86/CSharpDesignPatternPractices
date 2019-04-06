using System;
using System.Collections.Generic;

namespace ObseverPattern
{    
    class Program
    {

        interface IObserver
    {
        void Update (int i);
    }

    interface ISubject
    {
        void Register (IObserver o);
        void UnRegister (IObserver o);

        void NotifyRegisteredUsers (int i);
    }

    class Subject : ISubject
    {
        List<IObserver> observerItems = new List<IObserver> ();
        private int flag;
        public int Flag
        {
            get { return flag; }
            set
            {
                flag = value;
                NotifyRegisteredUsers (flag);
            }
        }

        public void NotifyRegisteredUsers (int i)
        {
            foreach (var observer in observerItems)
            {
                observer.Update (i);
            }
        }

        public void Register (IObserver o)
        {
            observerItems.Add (o);
        }

        public void UnRegister (IObserver o)
        {
            observerItems.Remove (o);
        }
    }

    class Observer1 : IObserver
    {
        private readonly string name;

        public Observer1 (string name)
        {
            this.name = name;
        }

        public void Update (int i)
        {
            System.Console.WriteLine ($"{name} has received an alert: Someone has updated myValue in Subject to {i}");
        }
    }
    class Observer2 : IObserver
    {
        private readonly string name;

        public Observer2 (string name)
        {
            this.name = name;
        }

        public void Update (int i)
        {
            System.Console.WriteLine ($"{name} has received an alert: Someone has updated myValue in Subject to {i}");
        }
    }
        static void Main (string[] args)
        {
            Console.WriteLine ("***Observer Pattern Demo***\n");
            //We have 3 observers-2 of them are ObserverType1, 1 of them  is of ObserverType2
            IObserver myObserver1 = new Observer1 ("Roy");
            IObserver myObserver2 = new Observer1 ("Kevin");
            IObserver myObserver3 = new Observer2 ("Bose");
            var subject = new Subject ();
            //Registering the observers-Roy,Kevin,Bose Chapter 14  Observer pattern
            subject.Register (myObserver1);
            subject.Register (myObserver2);
            subject.Register (myObserver3);
            Console.WriteLine (" Setting Flag = 5 ");
            subject.Flag = 5;
            //Unregistering an observer(Roy))
            subject.UnRegister (myObserver1);
            //No notification this time Roy. Since it is unregistered.
            Console.WriteLine ("\n Setting Flag = 50 ");
            subject.Flag = 50;
        }
    }
}