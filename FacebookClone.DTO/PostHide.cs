using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class PostHide (
		long ProfileId,
		long PostId,
		DateTimeOffset Begin,
		DateTimeOffset End,
		long HideStateId)
	{
	}
}
