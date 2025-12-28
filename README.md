# .Net
https://github.com/piyush56p/bharat-health-card
https://github.com/karamveer05s/Digital-Health-Card-System

using Microsoft.Data.SqlClient;  
class Program
{
    
    static string connectionString = "Server=localhost;Database=LoginAppDB;Integrated Security=True;TrustServerCertificate=True;";
   

    static void Main(string[] args)
    {
        Console.WriteLine("=== Simple Login ===");

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();  

        bool isValid = CheckCredentials(username, password);

        if (isValid)
        {
            Console.WriteLine("\nResult: Valid - Login Successful!");
        }
        else
        {
            Console.WriteLine("\nResult: Invalid - Wrong Username or Password");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static bool CheckCredentials(string username, string password)
    {
        
        
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(1) FROM emp WHERE Username = @abc AND Password = @abc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@abc", username);
                    cmd.Parameters.AddWithValue("@abc", password);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        
        
    }

   
    static string ReadPassword()
    {
        string pass = "";
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                pass += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
            {
                pass = pass.Substring(0, pass.Length - 1);
                Console.Write("\b \b");
            }
        }
        while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return pass;
    }
}
