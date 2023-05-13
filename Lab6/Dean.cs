using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Dean : IObservable
    {
        Grades grades;

        List<IObserver> observers;
        public Dean()
        {
            observers = new List<IObserver>();
            grades = new Grades();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(grades);
            }
        }

        public void Verify()
        {
            Random rnd = new Random();
            grades.Student = "Семен";
            grades.Grade = rnd.Next(2, 5);


            int range = 5 * 30; //5 months 
            DateTime randomDate = DateTime.Today.AddMonths(3).AddDays(-rnd.Next(range));

            grades.Time = randomDate;
            NotifyObservers();
        }

    }
}
