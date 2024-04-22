using System.Data.SqlClient;

namespace DesignPrincipalsImpliDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            SqlConnection sqlConnect;
            string connectingString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=FirstDatabase;Integrated Security=True;Trust Server Certificate=True";

            try
            {
                sqlConnect = new SqlConnection(connectingString);
                sqlConnect.Open();
                Console.WriteLine("connected");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
