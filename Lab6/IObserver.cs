using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    //internal interface IObserver<Observable> where Observable : IObservable
    //{
    //    void Update(Observable observable);
    //}

    internal interface IObserver
    {
        void Update(object observable);
    }
}
