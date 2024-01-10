﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClone.DTO
{
	public record class ProfileGroup (
		long GroupId,
		string Name,
		long MemberCount,
		long PostCount,
		bool IsPublic,
		string ImagePath)
	{
	}
}
