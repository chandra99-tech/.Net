namespace _11Demo_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Enter your Db choice. 1. SqlServer, 2. MySql Server, 3. Oracle Server");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                DataBaseFactory factory = new DataBaseFactory();
                DataBase someDatabaseObject = factory.GetSomeDatabase(dbChoice);
                Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        someDatabaseObject.Insert();
                        break;
                    case 2:
                        someDatabaseObject.Update();
                        break;
                    case 3:
                        someDatabaseObject.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Db operation Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }

        }
    }
}

    public abstract class DataBase
    {
        public Logger _logger = null;
        public DataBase()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDataBaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Insert From {GetDataBaseName()} done.");
        }
        public void Update()
        {
            DoUpdate();
            _logger.Log($"Update From {GetDataBaseName()} done.");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete From {GetDataBaseName()} done.");
        }
    }

    public class DataBaseFactory
    {
        public DataBase GetSomeDatabase(int dbChoice)
        {
            DataBase db = null;
            switch (dbChoice)
            {
                case 1:
                    db = new SqlServer();
                    break;
                case 2:
                    db = new MySqlServer();
                    break;
                case 3:
                    db = new OracleServer();
                    break;
                default:
                    db = null;
                    break;
            }
            return db;
        }
    }

    public class MySqlServer:DataBase
    {
        protected override string GetDataBaseName()
        {
            return "MySQL Server";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in MySql Successfully");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in MySql Successfully");
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from MySql Successfully");
        }
    }

    public class SqlServer : DataBase
    {
        protected override string GetDataBaseName()
        {
            return "SQL Server";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in SQL Successfully");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in SQL Successfully");
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from SQL Successfully");
        }
    }

    public class OracleServer : DataBase
    {
        protected override string GetDataBaseName()
        {
            return "Oracle Server";
        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in Oracle Successfully");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in Oracle Successfully");
        }

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted from Oracle Successfully");
        }
    }

    public class Logger
    {
        private static readonly Logger _logger1 = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger Object is created for the first time!..");
        }

        public static Logger GetLogger()
        {
            return _logger1;
        }

        public void Log(string message)
        {
            Console.WriteLine("---Logged at {0}, message : {1}", DateTime.Now.ToString(), message);
        }
    }

