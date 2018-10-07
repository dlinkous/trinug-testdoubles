using System;

namespace Type1.Testing
{
	internal class SpaceRepositoryTestDouble : ISpaceRepository
	{
		public Space Read(int identifier)
		{
			throw new NotSupportedException();
		}

		public void Update(Space space)
		{
			throw new NotSupportedException();
		}
	}
}
