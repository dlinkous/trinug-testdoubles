using System;
using System.Collections.Generic;

namespace Type5.Testing
{
	internal class SpaceRepositoryTestDouble : ISpaceRepository
	{
		internal Dictionary<int, Space> Spaces { get; } = new Dictionary<int, Space>();

		public Space Read(int identifier) => GetSpaceCopy(Spaces[identifier]);

		public void Update(Space space) => Spaces[space.Identifier] = GetSpaceCopy(space);

		private Space GetSpaceCopy(Space original) =>
			new Space()
			{
				Identifier = original.Identifier,
				Location = original.Location,
				IsReserved = original.IsReserved
			};
	}
}
