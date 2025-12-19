using Access_Specifier;

namespace Access_Specifier_Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CMath cMath = new CMath();
            cMath.Add(10, 20);

            MyMath my = new MyMath();
            my.Wrapper();

            AdvMath math= new AdvMath();
            math.Adv_Wrapper();
        }
    }

    public class MyMath : CMath
    {
        public void Wrapper()
        {
            base.Mul(2, 2);
            base.Square(8);
        }

        public void Mul(int p, int q)
        {
            base.Mul(p, q);
        }

    }
}
