using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EnterpriseMasterSite
{
    class SqlShipDb
    {
        private static string GetConnectionString()
        {
            return "Server = ASL-3PL-SQL01; Database = Ship; User Id = sa; Password = Antigen19lundberg62; Connection Timeout=600";
            //return "Server = apps; Database = WebServices; User Id = sa; Password = access; Connection Timeout=600";
            //return "Server = ASL-APP2; Database = TrackAndTrace; User Id = sa; Password = Icecool1; Connection Timeout=600";
        }

        public static DataSet Execute(string command)
        {
            SqlCommand sqlCommand = new SqlCommand(command, new SqlConnection(GetConnectionString()));
            sqlCommand.CommandTimeout = 700;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetData(string procName, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }
            command.CommandTimeout = 700;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);

            connection.Close();
            connection.Dispose();

            return ds;
        }

        public static DataSet GetData(string commandText)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();

            SqlCommand command = new SqlCommand(commandText, connection);
            command.CommandTimeout = 700;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);

            connection.Close();
            connection.Dispose();

            return ds;
        }

        public static object GetValue(string procName, string paramName, string value)
        {
            SqlParameter parameter = new SqlParameter(paramName, value);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(parameter);

            try
            {
                return GetData(procName, parameters).Tables[0].Rows[0][0];
            }
            catch (Exception er)
            {

            }
            return null;
        }

        public static object GetValue(string commandText, string field)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand(commandText, connection);

            object value = null;

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                int ordinal = reader.GetOrdinal(field);
                value = reader.GetValue(ordinal);
                reader.Close();
            }
            catch (Exception er)
            {

            }

            connection.Close();

            return value;
        }

        //For single row.
        public static DataRow GetValues(string procName, string paramName, string value)
        {
            SqlParameter parameter = new SqlParameter(paramName, value);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(parameter);

            try
            {
                return GetData(procName, parameters).Tables[0].Rows[0];
            }
            catch (Exception er)
            {

            }
            return null;
        }
    }
}
