using FacebookClone.DAL;
using FacebookClone.DTO;
using FileLoggingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.BLL
{
	public static class ProfileBLL
	{
		public static Profile? Profile { get; set; } = null;

		public static bool TryLogIn(string email, string password)
		{
			var table = DataProvider.GetTable($@"
SELECT
	ProfileId, FirstName, LastName,
	BirthDateUnixSecs, ImagePath,
	IsNotificationOff
FROM Profile
WHERE
	Email = '{email}' AND
	Password = '{password}'
");
			if (table is null || table.Rows.Count == 0)
			{
				FileLogger.Logger.Info($"Failed to log in: email '{email}' and password '{password}'");
				return false;
			}
			var row = table.Rows[0];
			Profile = new Profile(
				DataConverter.ToLong(row, "ProfileId")!.Value,
				DataConverter.ToString(row, "FirstName")!,
				DataConverter.ToString(row, "LastName")!,
				password,
				email,
				DataConverter.UnixSecsToDateOnly(row, "BirthDateUnixSecs")!.Value,
				DataConverter.ToString(row, "ImagePath"),
				DataConverter.ToBoolean(row, "IsNotificationOff")!.Value);
			return true;
		}

		public static bool IsEmailExists(string email)
		{
			string sql = $@"
SELECT Email
FROM Profile
WHERE Email = '{email}'";
			var table = DataProvider.GetTable(sql);
			if (table is null || table.Rows.Count == 0)
			{
				return false;
			}
			return true;
		}

		public static bool TrySignUp(
			string firstName, string lastName, string password, string email,
			DateOnly birthDate)
		{
			string sql = $@"
INSERT INTO Profile (
	FirstName, LastName, Password, Email,
	BirthDateUnixSecs, ImagePath, IsNotificationOff
)
VALUES (
	'{firstName}', '{lastName}', '{password}', '{email}',
	{DataConverter.DateOnlyToUnixSecs(birthDate)}, null, 0
);";
			int rowCount = DataProvider.ExecuteNonQuery(sql);
			return rowCount == 1;
		}
	}
}
