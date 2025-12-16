using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02.Logic
{
    internal class CMaths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y,int z)
        {
            return x + y+z;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public virtual void Mult(int a, int b)
        {
            Console.WriteLine("CMath Mult: {0}", (a * b));
        }

    }
    internal class AdvanceMath: CMaths
    {
        public override void Mult(int a, int b)
        {
           Console.WriteLine("Adv Math Mult: {0}", (a * b) * 100);
        }

        public new void Sub(int a, int b)
        {
            Console.WriteLine("Adv Math Sub: {0}", (a - b) * 2);
        }
        public void Add(int a, int b)
        {
            Console.WriteLine("Adv Math Add: {0}", (a + b) * 100);
        }

      
        public int Add(int a, int b, int p, int q)
        {
            return a + b + p + q;
        }
    }
}
