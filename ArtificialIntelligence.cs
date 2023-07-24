using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7q2
{
    internal class ArtificialIntelligence : InformationTechnology
    {
        public int FinancialAccounting;
        public void marks()
        {
            Console.WriteLine("Enter the marks of English: ");
            English = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Financial Accounting: ");
            FinancialAccounting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of ICT: ");
            ICT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Applied Physics: ");
            AppliedPhysics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Calculus: ");
            Calculus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of PF: ");
            PF = Convert.ToInt32(Console.ReadLine());
            obtainMarks = English + FinancialAccounting  + Calculus + PF + ICT + AppliedPhysics;
        }

        public void Percentage()
        {
            totalMarks = 600;
            percentage = (obtainMarks / totalMarks) * 100;
            Console.WriteLine("Your Percentage = {0}", percentage);
        }
    }
}
