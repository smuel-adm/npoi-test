using log4net;
using System.Data.SqlClient;

namespace npoi_tests
{
    public static class Sql 
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Sql));
        public static void ConnectToData(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                log.Debug("Try to open database: " + connectionString);
                connection.Open();
            }
        }

        public static string GetConnectionString()
        {
            string ado;
            // TODO: get connection string from config file or database
    #if DEBUG
            ado = "Data Source=(local); Database=SysproCompanyS;"
                + "Integrated Security=SSPI";
    #else
            ado = "Data Source=V-SX-SQL01; Database=SysproCompanyS;"
                    + "User Id=VBApplications;Password=password;";
    #endif
        log.Debug("ADO string: " + ado);
        return ado;
        }
    }
}