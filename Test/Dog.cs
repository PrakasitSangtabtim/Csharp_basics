using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    internal class Dog:Animal
    {
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string Display()
        {
            return Name;
        }
    }
}
