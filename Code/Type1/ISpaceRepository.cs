using System;

namespace Type1
{
	public interface ISpaceRepository
	{
		Space Read(int identifier);
		void Update(Space space);
	}
}
