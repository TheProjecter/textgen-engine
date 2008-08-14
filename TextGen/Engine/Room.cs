using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    class Room : Entity, ILocation, IContainer<Entity>
    {
        private List<ILocation> neighbors;
        private List<Entity> contents;

        public Room(string name, string description, List<ILocation> neighbors, List<Entity> contents)
            : base(name, description)
        {
            this.neighbors = neighbors;
            this.contents = contents;
        }

        #region Implementation of ILocation Interface
        public List<ILocation> Neighbors
        {
            get { return neighbors; }
        }

        public void AddNeighbor(ILocation location)
        {
            if (neighbors == null)
                neighbors = new List<ILocation>();
            neighbors.Add(location);
        }

        public bool RemoveNeighbor(ILocation location)
        {
            if (neighbors == null || neighbors.Count == 0)
                return false;
            return neighbors.Remove(location);
        }

        public bool IsNeighbor(ILocation location)
        {
            if (neighbors == null || neighbors.Count == 0)
                return false;
            return neighbors.Contains(location);
        } 
        #endregion

        #region Implementation of IContainer<Entity>

        public List<Entity> Contents
        {
            get { return contents; }
        }

        public bool CanAdd(Entity item)
        {
            return contents != null;
        }

        public bool Add(Entity item)
        {
            if(!CanAdd(item))
                return false;
            contents.Add(item);
            return true;
        }

        #endregion

        #region Overrides of Entity

        public override bool Display()
        {
            return false;
        }

        #endregion
    }
}
