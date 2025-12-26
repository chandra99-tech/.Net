using System.Collections;
using System.Linq;

namespace _08_1_Demo
{
    //public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a Number : ");
            //int no = Convert.ToInt32(Console.ReadLine());

            #region Normal Method
            //var result = check(no);
            //if(result)
            //{
            //    Console.WriteLine($"Entered No {no} is Greater then 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Entered No {no} is Not Greater then 10");
            //}
            #endregion

            #region Method Call Using Delegates
            //MyDelegate del = new MyDelegate(check);
            //var result = del(no);
            //if (result)
            //{
            //    Console.WriteLine($"Entered Number {no} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Entered Number {no} is not Greater then 10");
            //} 
            #endregion

            #region Anonymous Methods using Delegates and Delegates Keyword
            //MyDelegate del = new MyDelegate(delegate (int num) { return num > 10; });

            //MyDelegate del = delegate (int num) { return num > 10; };

            ////var result = del(no);
            //if (del(no))
            //{
            //    Console.WriteLine($"Entered No {no} is Greater then 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Entered No {no} is Not Greater then 10");
            //} 
            #endregion

            #region Lambada Expression => goes to operator
            //MyDelegate del = (int num) => { return num > 10; };

            //MyDelegate del = num => num > 10;

            //if (del(no))
            //{
            //    Console.WriteLine($"Entered No {no} is Greater then 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Entered No {no} is Not Greater then 10");
            //} 
            #endregion

            #region Predicates <T> built in type
            //Predicate<int> del = num => num > 10;

            //if (del(no))
            //{
            //    Console.WriteLine($"Entered No {no} is Greater then 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Entered No {no} is Not Greater then 10");
            //} 
            #endregion

            #region Built-In Extension Method and Normal MySum Method
            //int[] arr = { 1, 5, 6, 4 };
            //var result1 = arr.Sum();

            //Console.WriteLine($"Sum1 = {result1}");

            //var result2 = MySum(arr);
            //Console.WriteLine($"Sum2 = {result2}");

            //string[] names = { "Ayush", "Amol", "Chinmay", "Vinayak" };

            //var result3 = MySum(names).Substring(1);
            //var result4 = string.Join(", ", names);
            //Console.WriteLine($"Sum3 = {result3}");
            //Console.WriteLine($"Sum4 = {result4}"); 
            #endregion

            #region Regular Valid Email Id Checkin Code
            //Console.WriteLine("Enter Email Address :");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (MyClass.CheckValidEmail(email))
            //    {
            //        Console.WriteLine("Entered Email Address is a Valid Email");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entered Email Address is not valid ");
            //    }
            //}
            #endregion

            #region Extension Method : Demo 1 
            //Console.WriteLine("Enter Email Address :");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (email.CheckValidEmail())
            //    {
            //        Console.WriteLine("Entered Email Address is a Valid Email");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entered Email Address is not valid ");
            //    }
            //} 
            #endregion

            #region Extension Method : Demo 2
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //string[] days = { "Sunday", "Monay", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //List<int> outPut1 = numbers.ConvertToList(2101);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine($"Number = {item}");
            //}

            //List<string> outPut2 = days.ConvertToList(7498);
            //foreach (var item in outPut2)
            //{
            //    Console.WriteLine($"WeekDays = {item}");
            //} 
            #endregion

            #region Iterator
            #region Demo 1
            //int[] arr = { 1, 2, 3, 4, 5, 6, };
            //arr[6] = 7;
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>();
            //list.Add(11);  
            #endregion

            #region Demo 2
            MyCustomCollection customCollectionObject = new MyCustomCollection();

            customCollectionObject.AddElement(11);
            customCollectionObject.AddElement(12);
            customCollectionObject.AddElement(13);

            var result = customCollectionObject.GetElement;

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customCollectionObject)
            {
                Console.WriteLine($"--{item}");
            }

            MyCollection collection = new MyCollection();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            } 
            #endregion

            #endregion
        }

        private static bool check(int no)
        {
            return no > 10;
        }

        public static T MySum<T>(IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var ele in arr)
            {
                sum += ele;
            }

            return sum;
        }
    }

    public static class MyClass
    {
        public static bool CheckValidEmail(this string email)
        {
            return email.Contains("@gmail.com");
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int nonSenseParameter)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }

            Console.WriteLine($"NonSenseParameter = {nonSenseParameter}");
            return list;
        }
    }

    public class MyCustomCollection : IEnumerable
    {
        private ArrayList arr = new ArrayList();

        public ArrayList GetElement
        {
            get {  return arr; }
        }

        public void AddElement(int element)
        {
            arr.Add(element);
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                yield return arr[i];    
            }
        }
    }

    public class MyCollection : IEnumerable
    {
        private string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day;
            }
        }
    }
}
