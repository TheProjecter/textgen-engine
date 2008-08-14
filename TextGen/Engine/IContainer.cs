using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    interface IContainer<T>:IEntity
    {
        List<T> Contents { get; }
        bool CanAdd(T item);
        bool Add(T item);
    }
}
