using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
        void Disconnect();
    }

    public class SqlSereverDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connected To SqlSerevr Database!.");

        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from SqlServer database!");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Excuting query on SqlServer: {query}");
        }

    }
    public class MySqlDatabase : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connected To MySql Database!.");

        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from MySql database!");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Excuting query on MySql: {query}");
        }


    }


    public abstract class DatabaseAccess
    {
        protected IDatabase db;
        protected DatabaseAccess(IDatabase db)
        {
            this.db = db;
        }

        public abstract void PerformDatabaseOperations(string query);
    }

    public class ApplicationDatabaseAccess : DatabaseAccess
    {
        public ApplicationDatabaseAccess(IDatabase database) : base(database) { }

        public override void PerformDatabaseOperations(string query)
        {
            db.Connect();
            db.ExecuteQuery(query);
            db.Disconnect();
        }
    }
}
