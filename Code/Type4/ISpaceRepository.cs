﻿using System;

namespace Type4
{
	public interface ISpaceRepository
	{
		Space Read(int identifier);
		void Update(Space space);
	}
}
