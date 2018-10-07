using System;

namespace Type4.Testing
{
	internal class SpaceRepositoryTestDouble : ISpaceRepository
	{
		public Space Read(int identifier)
		{
			if (identifier < 100)
				return null;
			else
				return new Space()
				{
					Identifier = identifier,
					Location = 1,
					IsReserved = false
				};
		}

		public void Update(Space space) { }
	}
}
