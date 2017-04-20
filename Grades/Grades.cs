using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            double twos = 0.00;
            double trees = 0.00;
            double fours = 0.00;
            double fivesplus = 0.00;
            var gradeCount = 0;
            var average = 0.00;


            for (int i = 0; i < n; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade >= 5) fivesplus += 1;
                if (grade >= 4 && grade < 5) fours += 1;
                if (grade >= 3 && grade < 4) trees += 1;
                if (grade < 3) twos += 1;
                gradeCount += 1;
                average += grade;


            }
            Console.WriteLine("Top students: {0:f2}%",fivesplus/gradeCount*100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fours / gradeCount * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", trees/ gradeCount * 100);
            Console.WriteLine("Fail: {0:f2}%", twos / gradeCount * 100);
            Console.WriteLine("Average: {0:f2}", average / gradeCount);
        }
    }
}
