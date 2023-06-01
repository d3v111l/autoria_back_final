using MySqlConnector;

namespace autoria_back
{
    public class DBconnect
    {
        private MySqlConnection mySqlConnection = new MySqlConnection("server=mysql-20230530015021.mysql.database.azure.com;port=3306;username=d3v111l@mysql-20230530015021;database=likes;password=Knyzeva_1;Allow User Variables=true");

        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }

    }
}
