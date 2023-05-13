using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Lecturer : IObserver
    {
        public string Name { get; set; }
        IObservable? grades;
        public Lecturer(string name, IObservable obs)
        {
            this.Name = name;
            grades = obs;
            grades.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            Grades grades = ob as Grades;
            if (ob == null) return;

            Console.WriteLine(grades.Time);
            Console.Write("{0}:\t", Name);
            if (grades.Time <= DateTime.Today)
                Console.WriteLine("Преподаватель просрочил отчётность");
            else if (grades.Grade == 2)
                Console.WriteLine("У ученика {0} неуспеваемость по предмету, он получил {1}\n", grades.Student, grades.Grade);
            else
                Console.WriteLine("Отчёт пришёл, успеваемость в порядке");
        }
        public void StopGrades()
        {
            grades.RemoveObserver(this);
            grades = null;
        }
    }
}
