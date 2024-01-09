using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class GroupMember (
		long GroupId,
		long ProfileId,
		long GroupMemberRightId,
		DateTimeOffset Join)
	{
	}
}
