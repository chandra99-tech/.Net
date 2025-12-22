namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Emp emp1 = new Emp();
            emp1.EmployeeId = 101;
            emp1.EmpName = "Ayush";
            emp1.EmpAdd = "Pune";

            Emp emp2 = new Emp();
            emp2.EmployeeId = 102;
            emp2.EmpName = "Chandu";
            emp2.EmpAdd = "Chandrapur";

            Emp emp3 = new Emp();
            emp3.EmployeeId = 103;
            emp3.EmpName = "Chinmay";
            emp3.EmpAdd = "Amravati";

            List<Emp> elist= new List<Emp>();
            elist.Add(emp1);
            elist.Add(emp2);
            elist.Add(emp3);

            foreach (Emp emp in elist)
            {
                Console.WriteLine($"Employee ID = {emp.EmployeeId}, Employee Name = {emp.EmpName}, Employee Address = {emp.EmpAdd}");
            }

        }
    }

    public class Emp
    {
        private int _EmpId;
        private string _EmpName;
        private string _EmpAdd;

        public int EmployeeId
        {
            set
            {
                _EmpId = value;
            }
            get
            {
                return _EmpId;
            }
        }

        public string EmpName
        {
            set 
            {
                _EmpName = value; 
            }
            get 
            { 
                return _EmpName; 
            }
        }

        public string EmpAdd
        {
            set 
            { 
                _EmpAdd = value;
            }
            get
            { 
                return _EmpAdd;
            }
        }
    }
}
