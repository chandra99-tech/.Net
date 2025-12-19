namespace Access_Specifier
{
    public class CMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition = {x + y}");
        }
        private void Sub(int x, int y)
        {
            Console.WriteLine($"Substraction = {x-y}");
        }

        protected void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplications = {x * y}");
        }

        internal void Div(int x, int y)
        {
            if(y != 0)
            {
                Console.WriteLine($"Divide = {x / y}");
            }
            else
            {
                Console.WriteLine("Can't divide by zero");
            }  
        }

        protected internal void Square(int x)
        {
            Console.WriteLine($"Square = {x*x}");
        }
    }

    public class AdvMath : CMath
    {
        public void Adv_Wrapper()
        {
            base.Square(5);
            base.Mul(5, 6);
            base.Div(8, 2);
        }
    }
}
