using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance1
{
    class Distance1
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var t1 = int.Parse(Console.ReadLine());
            var t2 = int.Parse(Console.ReadLine());
            var t3 = int.Parse(Console.ReadLine());

            double min1 = t1 / 60D;
            double min2 = t2 / 60D;
            double min3 = t3 / 60D;

            double d1 = speed * min1;
            double d2 = (speed + speed * 0.1) * min2;
            double d3 = ((speed+ speed*0.1) - (speed + speed * 0.1) * 0.05) * min3;

            Console.WriteLine("{0:f2}",d1+d2+d3);

        }
    }
}
