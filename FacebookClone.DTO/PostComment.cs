using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class PostComment (
		long CommentId,
		long PostId,
		long ProfileId,
		string Content,
		DateTimeOffset Sent)
	{
	}
}
