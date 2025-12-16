using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02.Logic
{
    public interface IX
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }
    public interface IY
    {
        int Add(int x, int y);
        int Mult(int x, int y);
    }
    public interface IDemo
    {
        int Div(int x, int y);
        void Log(string message);
    }
    public class MyMath : IY, IDemo
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        void IDemo.Log(string message)
        {
            Console.WriteLine("Log msg : {0}", message);
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
