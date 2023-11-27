using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD_UI
{
	internal class DbConnector
	{
		private static string ConnectionString = "Host=192.168.1.48;Username=postgres;Password=P0stgrePass;Database=coddb";
		private NpgsqlConnection Connection = null;
		private static DbConnector _instance = null;


		public static DbConnector Instance
		{
			get
			{
				if (_instance == null) _instance = new DbConnector();
				return _instance;
			}
		}

		private DbConnector() { Connection = new NpgsqlConnection(ConnectionString); }


		public NpgsqlDataReader ExecuteSelect(string sqlSelectCommand)
		{
			if (Connection != null)
			{
				try
				{
					Connection.Open();

					NpgsqlCommand command = new NpgsqlCommand(sqlSelectCommand, Connection);
					NpgsqlDataReader reader = command.ExecuteReader();

					Connection.Close();
					return reader;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					
				}
			} 
			else
			{
                Console.WriteLine("Connection is null");
            }
			return null;
		}
	}
}
