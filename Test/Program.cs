using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] ags)
        {

            monkey m = new monkey("F", 7);

            string dos = m.Display();
           
            Console.WriteLine(dos);

        }
    }

   
 }
