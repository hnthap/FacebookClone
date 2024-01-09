using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Visibility (
		long VisibilityId,
		string Name)
	{
		public static Visibility FromRow(DataRow row)
		{
			return new Visibility(
				Convert.ToInt64(row["VisibilityId"]),
				Convert.ToString(row["Name"])!);
		}
	}
}
