using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5task1
{
    public class Human : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Human is moving.");
        }
    }
}
