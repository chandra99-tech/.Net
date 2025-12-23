using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\.Net\Day_6\BinarySerialization\file\data3.txt";

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.EmpName = "Chandu";
            emp.Addr = "Gondiya";

            FileStream fs = null;

            #region Seralizable
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Done");
            #endregion

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File Does Not Found!");
            }

            BinaryFormatter bf1 = new BinaryFormatter();
            Employee empData = bf1.Deserialize(fs) as Employee;
            fs.Close();

            Console.WriteLine($"ID = {empData.EmpId}, Name = {empData.EmpName}, Address = {empData.Addr}");
        }
    }

    [Serializable]
    public class Employee
    {
        
        private int _EmpId;
        private string _EmpName;

        [NonSerialized]
        private string _Addr;

        public string Addr
        {
            get { return  _Addr; }
            set { string _Addr = value; }
        }

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

    }
}
