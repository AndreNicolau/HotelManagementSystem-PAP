using System.Configuration;

namespace Hotel_Management_System
{
    internal class Helper
    {
        public static string ConnectionVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[ name ].ConnectionString;
        }
    }
}
