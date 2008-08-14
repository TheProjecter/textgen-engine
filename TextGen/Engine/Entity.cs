using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    abstract class Entity:IEntity
    {
        private string name;
        private string description;

        public virtual string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public virtual string Description
        {
            get { return description; }
            internal set { description = value; }
        }

        protected Entity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public abstract bool Display();
    }

    internal interface IEntity
    {
        string Name { get; }
        string Description { get; }
        bool Display();
    }
}
