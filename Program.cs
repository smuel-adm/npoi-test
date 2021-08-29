using System;
using System.Data;
using System.Data.SqlClient;

namespace npoi_tests
{
    public class Program
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger) =>
            _logger = logger;

        static void Main(string[] args)
        {
            const string BudgetFileLocation = "D:\\src\\C#\\npoi-tests";
            const string DETemplateName = "Template FC DE.xltx";
            const string ENGTemplateName = "Template FC ENG.xltx";
            const string BudgetSheetName = "Data";

            string connectionString = GetConnectionString();
            ConnectToData(connectionString);
        }

        private static void ConnectToData(string connectionString)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                System.Console.WriteLine("Try to open database: " + connectionString);
                connection.Open();
            }
        }

        private static string GetConnectionString() 
        {
            // TODO: get connection string from config file or database
#if DEBUG
            return "Data Source=(local); Database=SysproCompanyS;"
                + "Integrated Security=SSPI";
#else
            return "Data Source=V-SX-SQL01; Database=SysproCompanyS;"
                + "User Id=VBApplications;Password=password;";
#endif
        }
    }
}
