using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class People : IComposite<Person>, IEntity
    {

        private List<Person> _people;

        public People()
        {
            _people = new List<Person>();
        }

        public int Count => _people.Count;

        public float Weight { get => _people.Sum((p) => p.Weight); init => throw new NotImplementedException(); }

        public void Add(Person element)
        {
            _people.Add(element);
        }

        public Person? GetById(int id)
        {
            if (id < 0 || id >= Count) return null;
            return _people[id];
        }
    }
}
