using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_02.Logic
{
    public class MySqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Record Inserted in MySql Successfylly");
        }
        public void Update()
        {
            Console.WriteLine("Record Updated in MySql Successfylly");
        }
        public void Delete()
        {
            Console.WriteLine("Record Deleted from MySql Successfylly");
        }
    }
    public class SqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Record Inserted in SqlServer Successfylly");
        }
        public void Update()
        {
            Console.WriteLine("Record Updated in SqlServer Successfylly");
        }
        public void Delete()
        {
            Console.WriteLine("Record Deleted from SqlServer Successfylly");
        }
    }

    public class OracleServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Record Deleted from OracleServer Successfylly");
        }

        public void Insert()
        {
            Console.WriteLine("Record Inserted from OracleServer Successfylly");
        }

        public void Update()
        {
            Console.WriteLine("Record Updated from OracleServer Successfylly");
        }
    }
}

