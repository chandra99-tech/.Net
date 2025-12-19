using System.Net;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee obj = new Employee();
            obj.Eid = 1;
            obj.Name = "Ayush";
            obj.Address = "Pune";

            Console.WriteLine($"Eid ={obj.Eid}");
            Console.WriteLine($"Eid ={obj.Name}");

        }
    }
    public class Employee
    {
        private int _Eid;
        private string _Name;
        private string _Address;

        public int Eid
        {
            set
            {
                _Eid = value;
            }
            get
            {
                return _Eid;
            }
        }
        public string Name
        {
            set
            {
                if (value != null)
                {
                    _Name = "Mr/Mrs. " + value;
                }
                else
                {
                    Console.WriteLine("Invalid Credential");
                }
            }
            get 
            { 
                return _Name;

            }
        }

        public string Address
        {
            set
            {
                _Address = value;
                Console.WriteLine($"Address ={_Address}");
            }
        }

    }
}
