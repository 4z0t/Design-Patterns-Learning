using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IComposite<T> : IEntity
    {
        public int Count { get; }
        public T? GetById(int id);
        public void Add(T element);
        public bool Remove(int id);
    }
}
