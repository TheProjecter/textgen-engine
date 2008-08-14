using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    class Portal:Entity
    {
        private ILocation target;
        private bool canPass = true;

        #region Properties
        public ILocation Target
        {
            get
            {
                return target;
            }
            protected set
            {
                target = value;
            }
        }
        public virtual bool CanPass
        {
            get { return canPass; }
            protected set { canPass = value; }
        }

        public override string Description
        {
            get
            {
                return Description + (CanPass ? ", leading to:/r/n" + target.Description: " [Unpassable]");
            }
        }

        #endregion

        //Constructors, which require at minimum an ILocation target.
        #region Constructors
        public Portal(ILocation target, string name, string description)
            : base(name, description)
        {
            this.target = target;
        }

        public Portal(string description, ILocation target) :
            base("portal to " + target.Name, description)
        {
            this.target = target;
        }

        public Portal(ILocation target) :
            base("portal to " + target.Name, "the way to " + target.Name)
        {
            this.target = target;
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
