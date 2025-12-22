namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Books book = new Books();
            book.Author = "Test";
            book.BookName = "The Hobbit";

            Console.WriteLine(book.BookName);
            Console.WriteLine(book.Author);
        }
    }

    public class Books
    {
        private string _Author;
        private string _BookName;

        //public string BookName { get; set; }
        //public string Author { get; set; }

        public string BookName
        {
            set
            {
                _BookName = value;
            }
            get { return _BookName; }
        }

        public string Author
        {
            set
            {
                _Author = value;
            }
            get { return _Author; }
        }
    }
}
