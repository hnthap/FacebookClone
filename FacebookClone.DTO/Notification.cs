using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Notification (
		long NotificationId,
		string Content,
		DateTimeOffset Sent,
		long ProfileId,
		bool IsRead)
	{
	}
}
