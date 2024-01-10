using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DAL
{
	public static class DataConverter
	{
		private static DateTime _unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		private static TimeOnly _zeroTimeOnly = new TimeOnly(0, 0, 0);

		public static bool? ToBoolean(DataRow row, string column)
		{
			long? temp = ToLong(row, column);
			if (temp is null)
			{
				return null;
			}
			return Convert.ToBoolean(temp);
		}

		public static long? ToLong(DataRow row, string column)
		{
			if (Convert.IsDBNull(row[column]))
			{
				return null;
			}
			return Convert.ToInt64(row[column]);
		}

		public static DateOnly? UnixSecsToDateOnly(DataRow row, string column)
		{
			DateTimeOffset? temp = UnixSecsToDateTimeOffset(row, column);
			if (temp is null)
			{
				return null;
			}
			return DateOnly.FromDateTime(((DateTimeOffset)temp).Date);
		}

		public static long DateOnlyToUnixSecs(DateOnly date)
		{
			DateTime dateTime = date.ToDateTime(_zeroTimeOnly, DateTimeKind.Utc);
			return (long)(dateTime - _unixEpoch).TotalSeconds;
		}

		public static DateTimeOffset? UnixSecsToDateTimeOffset(DataRow row, string column)
		{
			long? unixSecs = ToLong(row, column);
			if (unixSecs is null)
			{
				return null;
			}
			return DateTimeOffset.FromUnixTimeSeconds((long)unixSecs);
		}

		public static string? ToString(DataRow row, string column)
		{
			if (Convert.IsDBNull(row[column]))
			{
				return null;
			}
			return Convert.ToString(row[column]);
		}
	}
}
