using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Blocking (
		long ProfileId,
		long BlockedProfileId)
	{
	}
}
