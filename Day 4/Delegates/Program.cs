namespace Delegates
{
    public delegate int DelegateAdd(int x, int y);
    public delegate int DelegateSub(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Cmath obj = new Cmath();
            DelegateAdd add = new DelegateAdd(obj.Add);
            int addresult = add(10, 12);
            Console.WriteLine(addresult);

            DelegateSub sub = new DelegateSub(obj.Subtract);
            int subresult = sub(10, 12);
            Console.WriteLine(subresult);
            
        }
    }
    public class Cmath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y) { return x - y; }
        
    }

}
