using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Class1
    {
        public static int enegyUserPerRun = 3;
        String color;

        private float enegy = 10;
        public int speed = 0;
        private int distant = 0;
    

        public Class1(String c, float e, int s, int d)
        {
            color = c;
            enegy = e;
            speed = s;
            distant = d;
        }

        public void AddEnegy()
        {
            enegy += 10;
        }

        public void Run()
        {
            if (enegy < speed * enegyUserPerRun)
            {
                Console.WriteLine("No enough enegy to run.");
            }
            else
            {
                distant += (speed * enegyUserPerRun);
                enegy -= enegyUserPerRun;
            }
        }

        public void ShowDistance()
        {
            Console.WriteLine("Distance runned " + distant);
        }

    }
}
