using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Profile (
		long ProfileId,
		string FirstName,
		string LastName,
		string Password,
		string Email,
		DateOnly BirthDate,
		string ImagePath,
		bool IsNotificationOff)
	{
	}
}
