namespace GenericDelegats
{
    public delegate T MyDelegats<T>();
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass<string> sample = new SampleClass<string>();
            MyDelegats<SampleClass<string>> del = new MyDelegats<SampleClass<string>>(sample.SampleMethod);
        }
    }

    public class SampleClass<T>
    {
        public void SampleMethod()
        {
            Console.WriteLine("Sample Method");
        }
    }
}
