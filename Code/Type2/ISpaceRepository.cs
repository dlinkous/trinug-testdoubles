﻿using System;

namespace Type2
{
	public interface ISpaceRepository
	{
		Space Read(int identifier);
		void Update(Space space);
	}
}
