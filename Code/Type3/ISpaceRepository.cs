using System;

namespace Type3
{
	public interface ISpaceRepository
	{
		Space Read(int identifier);
		void Update(Space space);
	}
}
