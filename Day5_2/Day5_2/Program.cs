using System;
using Oracle.DataAccess.Client; 

namespace Day5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "data source=topcredu;user id=scott;password=tiger";

            OracleConnection Conn = new OracleConnection(str);
            OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;

            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OracleDataReader reader = Comm.ExecuteReader(); 

                while(reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
