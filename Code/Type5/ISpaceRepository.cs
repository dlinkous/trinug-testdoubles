using System;

namespace Type5
{
	public interface ISpaceRepository
	{
		Space Read(int identifier);
		void Update(Space space);
	}
}
