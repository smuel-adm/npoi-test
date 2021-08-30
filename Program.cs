using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace npoi_tests
{
    public static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        public static void Main(string[] args)
        {

            log.Info("Entering application.");

            const string BudgetFileLocation = "D:\\src\\C#\\npoi-tests";
            const string DETemplateName = "Template FC DE.xltx";
            const string ENGTemplateName = "Template FC ENG.xltx";
            const string BudgetSheetName = "Data";

            string connectionString = Sql.GetConnectionString();
            Sql.ConnectToData(connectionString);

        }
    }
}
