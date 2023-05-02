using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Animal
    {
        private string name;
        private double age;
        public string Name { get { return name; } set { name = value; } }
        
        public double Age { get { return age; } set { age = value; } }

        public virtual string Display()
        {
            return Name;
        }
    }
}
