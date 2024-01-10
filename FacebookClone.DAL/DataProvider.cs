using FileLoggingLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DAL
{
	public static class DataProvider
	{
		private static string _connectionString =
			@"Data Source=banking.db;Version=3;Foreign Key=True;";

		public static SQLiteConnection Connect()
		{
			return new SQLiteConnection(_connectionString);
		}

		public static DataTable GetTable(string sql)
		{
			DataTable table = new();
			using var conn = Connect();
			conn.Open();
			using var adapter = new SQLiteDataAdapter(sql, conn);
			adapter.Fill(table);
			return table;
		}

		public static int ExecuteNonQuery(string sql)
		{
			try
			{
				using var conn = Connect();
				conn.Open();
				using var cmd = new SQLiteCommand(sql, conn);
				return cmd.ExecuteNonQuery();
			}
			catch
			{
				return -1;
			}
		}

		public static bool TryExecuteNonQueryScript(string resource)
		{
			var assembly = Assembly.GetExecutingAssembly();
			using var stream = assembly.GetManifestResourceStream(resource);
			if (stream is null)
			{
				FileLogger.Logger.Trace($"stream is null while resource is {resource}");
				return false;
			}
			using var reader = new StreamReader(stream);
			string script = reader.ReadToEnd();
			return ExecuteNonQuery(script) != -1;
		}

		public static bool TryReset()
		{
			foreach (string resource in new[]
			{
				"FacebookClone.DAL.sqlite.00-drop.sql",
				"FacebookClone.DAL.sqlite.01-initialize.sql",
				"FacebookClone.DAL.sqlite.02-populate.sql"
			})
			{
				if (!TryExecuteNonQueryScript(resource))
				{
					return false;
				}
			}
			return true;
		}
	}
}
