namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference
            //int a = 10;
            //int b = 20;
            //CMath cMath = new CMath();
            //Console.WriteLine($"Befor Swapping A={a} and B={b}");
            //cMath.Swap(ref a, ref b);
            //Console.WriteLine($"After Swapping A={a} and B={b}");
            #endregion

            #region Generic Template
            //int a = 15;
            //int b = 30;
            //CMath cMath = new CMath();
            //Console.WriteLine($"Before Swapping A={a} and B={b}");
            //cMath.swap<int>(ref a, ref b);
            //Console.WriteLine($"Before Swapping A={a} and B={b}");
            #endregion

            #region Generic OverLoading Demo Method
            //CMath cMath = new CMath();
            //double result = cMath.demo<int, string, double, bool>(101, "Ash", 45.25, true);
            //Console.WriteLine($"Double D = {result}");

            //char result1 = cMath.demo<int, string, double,char, bool>(201, "Chandu", 85.25,'C', true);
            //Console.WriteLine($"Character = {result1}");
            #endregion

            #region Dynamic Type
            //CMath cMath = new CMath();
            //Console.WriteLine(cMath.Add<int>(5,10));
            //Console.WriteLine(cMath.Add<string>("5", "10"));
            //Console.WriteLine(cMath.Add<double>(5.2, 10.5));
            #endregion

            #region Out parameter
            //double area, circumference = 0;
            //double radius = 5;
            //CMath cMath = new CMath();
            //cMath.CalculateCircleArea(radius,out area,out circumference);

            //Console.WriteLine($"Circle Radius = {radius}, \nCircle Area = {area}, \nCircle Circumference = {circumference} ");
            #endregion

            #region Generic Class with Generic and Non-Generic Methods
            //Console.WriteLine();
            //MyClass<string> myClass = new MyClass<string>();
            //myClass.SayHello("Ayush Jadhav");
            //Console.WriteLine(myClass.DoubleValue(10));
            #endregion

            #region Params Key
            int[] number = new int[3];
            number[0] = 10;
            number[1] = 20;
            number[2] = 30;

            Demo demo = new Demo();
            demo.Add(number);

            demo.PlayerName(101, "Ronaldo", "Messi");
            #endregion



        }
    }

    public class CMath
    {
        #region Reference Swap Template
        //public void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region Generic Template
        public void swap<T>(ref  T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Generic Overload Method
        public R demo<P,Q,R,S>(P a, Q b, R c, S d)
        {
            return c;
        }

        public T4 demo<T1,T2,T3,T4,T5>(T1 a, T2 b, T3 c, T4 d, T5 e)
        {
            return d;
        }
        #endregion

        #region Dynamic Type
        public T Add<T>(T x , T y)
        {
            dynamic para1 = x;
            dynamic para2 = y;
            dynamic sum = para1 + para2;
            return sum;
        }
        #endregion

        #region Out Parameter
        public void CalculateCircleArea(double radius, out double area, out double circumference)
        {
            area = 3.14 * radius * radius;

            circumference = 2 * 3.14 * radius;

        }
        #endregion

    }

    public class MyClass<T>
    {
        public void SayHello(T para)
        {
            Console.WriteLine($"Hello {para}");
        }

        public int DoubleValue(int x)
        {
            return x * 2;
        }
    }

    public class Demo
    {
        public void Add(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum = {sum}");
        }

        public void PlayerName(int x, params string[] nm)
        {
            string output = "Player Name : ";
            for(int i = 0;i < nm.Length;i++)
            {
                output += nm[i] + " ";
            }
            Console.WriteLine(output);
            Console.WriteLine(x);
        }
    }
}
