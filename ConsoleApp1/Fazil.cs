using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Fazil : Person, IEngineer
    {
        void IEngineer.lead()
        {
            Console.WriteLine("Lead the team");
        }
    }
}
