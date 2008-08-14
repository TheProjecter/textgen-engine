using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    interface ILocation:IEntity
    {
        List<ILocation> Neighbors { get; }
        void AddNeighbor(ILocation location);
        bool RemoveNeighbor(ILocation location);
        bool IsNeighbor(ILocation location);
    }
}
