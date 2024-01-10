using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Post (
		long PostId,
		string Content,
		long VisibilityId,
		DateTimeOffset Posted,
		long ReactionCount,
		long CommentCount,
		long ShareCount,
		string? Location,
		long? MemoryId)
	{
	}
}
