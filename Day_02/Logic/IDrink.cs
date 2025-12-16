using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02.Logic
{
    public interface IDrink
    {
        void GetDrink();
    }
    public class ColdDrink : IDrink
    {
        public void GetDrink()
        {
            Console.WriteLine("Enjoy your Cold Drink!!");
        }
    }
    public class HotDrink : IDrink
    {
        public void GetDrink()
        {
            Console.WriteLine("Enjoy your Hot Drink!!");
        }
    }
}
