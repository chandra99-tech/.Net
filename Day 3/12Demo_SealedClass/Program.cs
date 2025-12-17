namespace _12Demo_SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public sealed class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    public class AdvanceMath
    {
        public virtual int Square(int x)
        {
            return x * x;
        }
    }

    public class Math : AdvanceMath
    {
        public virtual void sayHello()
        {
            Console.WriteLine("Hello");
        }

        public sealed override int Square(int x)
        {
            return x*x*100;
        }

    }

    public class MyMath : CMath
    {
        public override void sayHello()
        {
            Console.WriteLine("Hello there!");
        }
    }
}
