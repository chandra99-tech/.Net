using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02.Logic
{
    internal class BaseClass
    {
        private int _baseNumber;
        public BaseClass() { 
        
        }
        public BaseClass(int x)
        {
            _baseNumber = x;
            Console.WriteLine("You passed num = {0}", _baseNumber);
        }
        public void Method1()
        {
            Console.WriteLine("MEthod1 from Base CLass");
        }

    }

    internal class DerivedClass : BaseClass
    {
        public DerivedClass() 
        {

        }

        public DerivedClass(int no):base(no) { 

        }
        public void Method2()
        {
            Console.WriteLine("MEthod2 from Derived CLass");
        }
    }
}
