using System;
using System.Collections.Generic;
using System.Text;

namespace SeventeenLab
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            // This implementation handles a null obj argument.
            Person p = obj as Person;
            if (p == null)
                return false;
            else
                return this.Name.Equals(p.Name);
        }
    }

   
}
