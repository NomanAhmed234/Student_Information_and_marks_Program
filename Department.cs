using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7q2
{
    internal class Department
    {
        public string name;
        public string id;
        public string depart;
        public void details()
        {
            Console.WriteLine("Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your id: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter Your Department: ");
            depart = Console.ReadLine();
        }

        public void select()
        {
            if (depart == "CS" || depart == "cs")
            {
                ComputerScience cs = new ComputerScience();
                cs.marks();
                cs.Percentage();
            }
            else if (depart == "SE" || depart == "se")
            {
                SoftwareEngineering se = new SoftwareEngineering();
                se.marks();
                se.Percentage();
            }
            else if (depart == "IT" || depart == "it")
            {
                InformationTechnology it = new InformationTechnology();
                it.marks();
                it.Percentage();
            }
            else if (depart == "AI" || depart == "ai")
            {
                ArtificialIntelligence ai = new ArtificialIntelligence();
                ai.marks();
                ai.Percentage();
            }
        }
    }
}
