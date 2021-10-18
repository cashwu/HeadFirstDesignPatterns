using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new MySubject();

            var observerA = new ObserverA();
            var observerB = new ObserverB();

            subject.Register(observerA);
            subject.Register(observerB);

            subject.StateChange(1);

            subject.Remove(observerA);

            subject.StateChange(2);
        }
    }

    public class MySubject : ISubject
    {
        private readonly List<IMyObserver> _observers;

        public MySubject()
        {
            _observers = new List<IMyObserver>();
        }

        public int State { get; private set; }

        public void Register(IMyObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IMyObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
                // observer.Update(State);
            }
        }

        public void StateChange(int state)
        {
            State = state;

            Notify();
        }
    }

    public interface IMyObserver
    {
        // pass data
        void Update(ISubject subject);
        // void Update(int state);
    }

    public interface ISubject
    {
        void Register(IMyObserver observer);

        void Remove(IMyObserver observer);

        void Notify();
    }

    public class ObserverB : IMyObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine($"{nameof(ObserverB)} notify state change - {((MySubject) subject).State}");
        }

        // public void Update(int state)
        // {
        //     Console.WriteLine($"{nameof(ObserverB)} notify state change - {state}");
        // }
    }

    public class ObserverA : IMyObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine($"{nameof(ObserverA)} notify state change - {((MySubject) subject).State}");
        }

        // public void Update(int state)
        // {
        //     Console.WriteLine($"{nameof(ObserverA)} notify state change - {state}");
        // }
    }
}