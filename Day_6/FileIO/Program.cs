namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\.Net\Day_6\FileIO\file\data1.txt";
            FileStream fs = null;
            #region OpenFileStream
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //StreamWriter writer = new StreamWriter(fs);
            //writer.WriteLine("Hello from Iet");
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done");
            #endregion

            #region readFileStream
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File Does not Exist");
            }

            StreamReader reader = new StreamReader(fs);
            string line = reader.ReadToEnd();
            reader.Close();
            fs.Close();
            Console.WriteLine(line); 
            #endregion

            Employee obj = new Employee();
            obj.EmpID= 1;
            obj.Name= "Ayush";
            obj.Addr = "Pune";

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writter = new StreamWriter(fs);
            writter.WriteLine(obj.EmpID+", "+obj.Name+", "+obj.Addr);
            writter.Flush();
            writter.Close();
            fs.Close();
            Console.WriteLine("Done Employee Added Successfully!");
        }
    }

    public class Employee
    {
        private int _EmpId;
        private string _Name;
        private string _Addr;

        
        public int EmpID
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Addr
        {
            get { return _Addr; }
            set { _Addr = value; }
        }

    }
}
