using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7q2
{
    internal class SoftwareEngineering : Department
    {
        public int English, Pst, ICT, AppliedPhysics, Calculus, PF;
        public double percentage, obtainMarks, totalMarks = 600;

        public void marks()
        {
            Console.WriteLine("Enter the marks of English: ");
            English = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Pst: ");
            Pst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of ICT: ");
            ICT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Applied Physics: ");
            AppliedPhysics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Calculus: ");
            Calculus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of PF: ");
            PF = Convert.ToInt32(Console.ReadLine());
            obtainMarks = English + Pst + Calculus + PF + ICT + AppliedPhysics ;
        }

        public void Percentage()
        {
            percentage = (obtainMarks / totalMarks) * 100;
            Console.WriteLine("You gain {0} in the final exam.", percentage);
        }
    }
}
