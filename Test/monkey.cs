using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    internal class monkey : Animal
    {
        public monkey(string name,int age) {
            Name = name;
            Age = age;
        } 


        public override string Display()
        {
            return Name + Age;
        }



    }
}
