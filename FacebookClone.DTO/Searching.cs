using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Searching (
		long ProfileId,
		DateTimeOffset Searched,
		string Prompt)
	{
	}
}
