namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern Programm");

            int num2 = Convert.ToInt32 (Console.ReadLine());


            for (int i = 0; i < num2; i++)
            {
                for (int j = 0; j < num2-i-1; j++)
                    Console.Write(" ");

                for (int j = 0; j < 2*i+1; j++) 
                {
                    if (j==0 || j==2*i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            for (int i = num2-2; i >=0; i--)
            {
                for (int j = 0; j < num2 - i - 1; j++)
                    Console.Write(" ");

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (j == 0 || j == 2 * i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }


        }
    }
}
