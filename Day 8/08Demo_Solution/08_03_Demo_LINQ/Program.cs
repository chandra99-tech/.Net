namespace _08_03_Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>() {

                new Emp() { Id = 1, Name = "Ayush", Address = "Sangli" },
                new Emp() { Id = 2, Name = "Amol", Address = "Latur" },
                new Emp() { Id = 3, Name = "Chinmay", Address = "Latur" },
                new Emp() { Id = 4, Name = "Chandrakant", Address = "Gondiya" },
                new Emp() { Id = 5, Name = "Vinayak", Address = "Sambhaji Nagar" },
                new Emp() { Id = 6, Name = "Atharva", Address = "kolhapur" },
                new Emp() { Id = 7, Name = "Amit", Address = "Sangli" },
                new Emp() { Id = 8, Name = "Omkar", Address = "Mumbai" },
                new Emp() { Id = 9, Name = "Hrushi", Address = "Pune" }
            };

            #region Filter Cities
            Console.WriteLine("Enter city:");
            string? city = Console.ReadLine().ToLower();

            Func<Emp, bool> del = emp => emp.Address.ToLower() == city;

            foreach (Emp emp in emps)
            {
                //if(emp.Address.ToLower() == city)
                if (del(emp))
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                }
            }
            #endregion
        }
    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
