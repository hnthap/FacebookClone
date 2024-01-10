﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class Following (
		long ProfileId,
		long FollowedProfileId)
	{
	}
}
