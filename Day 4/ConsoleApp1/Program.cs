namespace ConsoleApp1
{
    public delegate void MyHandler(int mark);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student._Pass += new MyHandler(student.Student_pass);
            student._Fail += new MyHandler(student.Student_fail);
            student.Mark =Convert.ToInt32(Console.ReadLine());
          
            student.TriggerEvent(student.Mark);


        }
    }
    public class Student
    {
        public event MyHandler _Pass;
        public event MyHandler _Fail;

        private int _Marks;
        public int Mark
        {
            set
            {
                _Marks = value;
                if (_Marks > 40)
                {
                    _Pass(_Marks);
                }
                else
                {
                    _Fail(_Marks);
                }
            }
            get
            { 
                return _Marks;
            }
           

        }
        public void TriggerEvent(int mark)
        { 
            if(Mark > 40)
            {
                _Pass(_Marks);
            }
            else
            {
                _Fail(_Marks);
            }
        }
        public void Student_pass(int mark)
        {
            Console.WriteLine("Congratulation !! You are passed with {mark} marks ");
        }
        public void Student_fail(int mark)
        {
            Console.WriteLine("Congratulation !! You are failed with {mark} marks ");
        }
    }
}
