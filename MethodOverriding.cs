using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BasicPractice
{
    class MethodOverriding
    {
        public static void Main(string[]args)
        {
            Bank1 b1 = new Bank1();
            b1.Roi();
            Bank2 b2 = new Bank2();
            b2.Roi();
            Bank1 b3 = new Bank2();
            b3.Roi();
        }
    }
    class Bank1
    {
        public virtual float Roi()
        {
            float irr = 4.5f;
            Console.WriteLine(irr);
            return irr;
        }
    }
    class Bank2 :Bank1
    {
        public override float Roi()
        {
            float ir = 10.5f;
            Console.WriteLine(ir);
            return ir;
        }
    }
}
