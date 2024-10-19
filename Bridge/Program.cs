using Bridge;

class Program
{
    static void Main(string[] args)
    {
        IDatabase mySQL = new MySqlDatabase();
        DatabaseAccess mySQLAccess = new ApplicationDatabaseAccess(mySQL);
        mySQLAccess.PerformDatabaseOperations("SELECT * FROM Users");

        IDatabase postgreSQL = new SqlSereverDatabase();
        DatabaseAccess postgreSQLAccess = new ApplicationDatabaseAccess(postgreSQL);
        postgreSQLAccess.PerformDatabaseOperations("SELECT * FROM Products");
    }
}