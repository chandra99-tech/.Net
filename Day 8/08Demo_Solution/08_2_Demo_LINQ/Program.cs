namespace _08_2_Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicates & Delegates
            //Predicate<int> _Even = x => x % 2 == 0;
            //Predicate<int> _Odd = x => x % 2 != 0;

            //Console.WriteLine("Enter A Number : ");
            //int no = Convert.ToInt32(Console.ReadLine());

            //var Even = _Even(no);
            //var Odd = _Odd(no);

            //Console.WriteLine($"Even = {Even}\nOdd = {Odd}"); 
            #endregion

            #region Action Delegates
            //Action actionDel = new Action(delegate () { Console.WriteLine("Hello IET CDAC"); });

            //actionDel();

            //Action actionDel1 = delegate { Console.WriteLine("What's Up Buddy!"); };

            //actionDel1();

            //Action actionDel2 = () => { Console.WriteLine("Any New Update!"); };

            //actionDel2(); 
            #endregion

            #region Function <Out Result>
            //Func<int> func = delegate () { return 1; };

            //var result1 = func();
            //Console.WriteLine(result1);

            //Func<double> func1 = delegate () { return 70.80; };

            //var result2 = func1();
            //Console.WriteLine(result2);

            //Func<string> func2 = delegate () { return "IET CDAC PUNE"; };

            //var result3 = func2();
            //Console.WriteLine(result3); 
            #endregion

            #region Func <in T, OutTResult>
            //Func<int, bool> func = new Func<int, bool>(
            //        delegate (int x)
            //        {
            //            return x % 2 == 0;
            //        }
            //    );

            //bool result = func(10);
            //Console.WriteLine(result);

            //Func<int, bool> del = new Func<int, bool>(x => x % 2 == 0);

            //bool result1 = del(15);
            //Console.WriteLine(result1);

            //Predicate<int> del1 = x => x % 2 == 0;
            //Predicate<int> del2 = x => x % 2 != 0;
            //Predicate<int> del3 = x => x == 12;

            //bool result2 = del3(15);
            //Console.WriteLine(result2);

            //Func<int, bool> func1 = new Func<int, bool>(del3);

            //bool result3 = func1(12);
            //Console.WriteLine(result3); 
            #endregion

            #region In-Built Where Extension Method
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine($"Sum = {arr.Sum()}");
            //Console.WriteLine($"Max = {arr.Max()}");

            //Predicate<int> _predicate1 = x => x == 5;

            //Func<int, bool> del = new Func<int, bool>(_predicate1);

            //var result = arr.Where(del);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Predicate<int> _predicate2 = x => x % 2 == 0;

            //Func<int, bool> del1 = new Func<int, bool>(_predicate2);

            //var result2 = arr.Where(del1);
            ////var result2 = arr.Where(x => x % 2 == 0);

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region In-Built Select Method
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Func<int, int> del = new Func<int, int>(no => no * 2);
            //var result1 = arr.Select(del);
            ////var result = arr.Select(no => no * 2);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Own Where and Select Methods
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> list = arr.MySelect();

            Func<int, bool> predicate = x => x % 2 == 0;
            list.MyWhere<int>(predicate);

            var EvenNum = list.MyWhere<int>(x => x % 2 == 0);
            foreach (var item in EvenNum)
            {
                Console.WriteLine(item);
            }

            var Even = list.MySelect().MyWhere<int>(x => x % 2 == 0);

            foreach (var item in Even)
            {
                Console.WriteLine(item);
            } 
            #endregion
        }
    }

    public static class MyClass
    {
        public static List<T> MySelect<T>(this IEnumerable<T> source)
        {
            var list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }

            return list;
        }

        public static IEnumerable<int> MyWhere<T>(this IEnumerable<int> source, Func<int, bool> predicate)
        {
            List<int> list = new List<int>();
            foreach (var item in source)
            {
                if(predicate(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
