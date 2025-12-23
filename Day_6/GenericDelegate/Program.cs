namespace GenericDelegate
{

    public delegate void MyDelegate1();
    public delegate void MyDelegate2<T>(T para1);
    public delegate void MyDelegate3<T1,T2>(T1 para1, T2 para2);
    public delegate void MyDelegate4<T>(T para1);
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo Generic Delegates
            //Demo demo = new Demo();
            //MyDelegate1 del1 = demo.sayHi;
            //del1();

            //MyDelegate2<string> del2 = demo.sayHello;
            //del2("Ayush");

            //MyDelegate3<string, string> del3 = demo.Greet;
            //del3("Chandrakant", "Thank You Coming To Party");

            //MyDelegate4<int> del4 = demo.Display;
            //del4(100);  
            #endregion

            Demo demo = new Demo(); 
            Math math = new Math();

            //MyDelegate3<string, string> del3 = demo.Greet;

            MyDelegate2<string> del3 = demo.sayHello;

            math.Test<string, string>(del3, "Ayush Jadhav");
        }
    }
    public class Demo
    {
        public void sayHi()
        {
            Console.WriteLine("Hello World!");
        }

        public void sayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void Greet(string name, string msg)
        {
            Console.WriteLine($"Hello, {name}, {msg}");
        }

        public void Display(int number)
        {
            Console.WriteLine($"Number is = {number}");
        }
    }

    public class Math
    {
        public void Test<T1,T3>(MyDelegate2<T1> del, T3 para1)
        {
            dynamic p1 = para1;
            del.Invoke(p1);
        }
    }
}
