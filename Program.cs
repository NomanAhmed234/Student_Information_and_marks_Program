/*Generate a marksheet of different departments with proper record and calculate
percentage with average of different subjects using Multilevel inheritance.
*/

namespace Lab_7q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dp1 = new Department();
            dp1.details();
            dp1.select();
        }
    }
}