using Day_02.Logic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Day_02
{
    internal class Program
    {
        
         
        static void Main(string[] args)
        {

            // 1.DataType 1 for their Size
            #region MyRegion
            //Console.WriteLine($"int : size{sizeof(int)}, min :{int.MinValue},max :{int.MaxValue}");
            //Console.WriteLine($"double : size{sizeof(double)}, min :{double.MinValue},max :{double.MaxValue}");
            //Console.WriteLine($"float : size{sizeof(float)}, min :{float.MinValue},max :{float.MaxValue}");
            //Console.WriteLine($"char : size{sizeof(char)}, min :{char.MinValue},max :{char.MaxValue}");
            //Console.WriteLine($"bool : size{sizeof(bool)}");  
            #endregion

            // 2.DataTye 2 for overFlow
            #region MyRegion
            //int a = int.MaxValue;
            //int b = a + 1;
            //Console.WriteLine(b);
            #endregion;

            // 3.Floating Point Precision
            #region MyRegion
            //float val1 = 0.1f + 0.2f;
            //double val2 = 0.1 + 0.2;
            //decimal val3 = 0.1m + 0.2m;
            //Console.WriteLine(val1 == 0.3f);
            //Console.WriteLine(val2 == 0.3);
            //Console.WriteLine(val3 == 0.3m); 
            #endregion;

            // 4.Character
            #region MyRegion
            //char c = 'A';
            //string s = "Hello from .Net";
            //Console.WriteLine(char.IsDigit(c));
            //Console.WriteLine(s.Length);
            //Console.WriteLine(s.ToUpper()); 
            #endregion

            // 5.Implicit and Explicit Conversion
            #region MyRegion
            //int x = 10;
            //long y = x;
            //int j = (int)y;
            //Console.WriteLine(y);
            //Console.WriteLine(x);
            //Console.WriteLine(j); 
            #endregion

            //6.Value Types vs Reference Types
            #region MyRegion
            //int x = 10;
            //int y = x;
            //y = 20;
            //Console.WriteLine(y);

            //Class1 p1 = new Class1
            //{
            //    name = "Chandrakant"
            //};
            //Class1 p2 = p1;
            //p2.name = "Ayush";
            //Console.WriteLine(p2.name); 
            #endregion

            //8.Boxing and Unboxing
            #region MyRegion
            //int n = 10;
            //Object boxing = n;
            //Console.WriteLine(boxing);
            //int unboxing = (int)boxing;
            //Console.WriteLine(unboxing); 
            #endregion

            //9. Inheritance problem 1
            #region MyRegion
            //Person p1 = new Person();
            //p1.first_name = "Chandrakant";
            //p1.last_name = "Palandurkar";
            //Console.WriteLine(p1.first_name);

            //Employee e1 = new Employee();
            //e1.employee_id = 1001;
            //Console.WriteLine(e1.employee_id); 
            #endregion

            //10. Inheritance 2
            #region MyRegion
            //BaseClass bs = new BaseClass();
            //bs.Method1();
            //BaseClass bs2 = new DerivedClass();
            //bs2.Method1();
            //DerivedClass bs3 = new DerivedClass();
            //bs3.Method1();
            //bs3.Method2(); 
            #endregion

            // 11.Overloading 
            #region MyRegion
            //AdvanceMath advMath = new AdvanceMath();
            //Console.WriteLine(advMath.Add(1, 2, 3, 4));
            //advMath.Sub(10, 5); 
            #endregion

            // 12.Overiding
            #region MyRegion
            //AdvanceMath advMath1 = new AdvanceMath();
            //advMath1.Sub(10, 5);
            //advMath1.Mult(10, 5);
            //advMath1.Add(10, 5); 
            #endregion

            //13.Interface 1
            #region MyRegion

            //Console.WriteLine("Enter your choice");
            //int ch = Convert.ToInt32(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        IDrink coldDrink = new ColdDrink();
            //        coldDrink.GetDrink();
            //        break;
            //    case 2:
            //        IDrink hotDrink = new HotDrink();
            //        hotDrink.GetDrink();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;
            //} 
            #endregion

            //14.Interface 2
            #region MyRegion
            //Console.WriteLine("Enter your choice 1. IX, 2. IY");
            //int ch = Convert.ToInt32(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        IX xObj = new CMath();
            //        Console.WriteLine(xObj.Add(10, 20));
            //        Console.WriteLine(xObj.Sub(20, 10));
            //        break;
            //    case 2:
            //        IY yObj = new CMath();
            //        Console.WriteLine(yObj.Add(10, 20));
            //        Console.WriteLine(yObj.Mult(10, 20));
            //        break;

            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break; 
            #endregion

            // 15.MySql
            #region MyRegion
            //MySqlServer mysql = new MySqlServer();
            //mysql.Insert();
            //mysql.Update();
            //mysql.Delete();




            //Console.WriteLine("Enter your Db choice. 1. SqlServer, 2. MySql Server, 3. Oracle Server");
            //int dbChoice = Convert.ToInt32(Console.ReadLine());

           //DataBaseFactory factory = new DataBaseFactory();
            //IDatabase someDatabaseObject = factory.GetSomeDatabase(dbChoice);
            //Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
            //int opChoice = Convert.ToInt32(Console.ReadLine());
            //switch (opChoice)
            //{
            //    case 1:
            //        someDatabaseObject.Insert();
            //        break;
            //    case 2:
            //        someDatabaseObject.Update();
            //        break;
            //    case 3:
            //        someDatabaseObject.Delete();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Db operation Choice");
            //        break;
            //} 
            #endregion
            

        }

    }

}




