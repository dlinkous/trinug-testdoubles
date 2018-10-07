using System;

namespace Type5
{
	public class ReservationService
	{
		private readonly ISpaceRepository spaceRepository;

		public ReservationService(ISpaceRepository spaceRepository)
		{
			this.spaceRepository = spaceRepository;
		}

		public bool Reserve(int identifier)
		{
			if (identifier <= 0) throw new ArgumentException(nameof(identifier));
			var space = spaceRepository.Read(identifier);
			if (space == null) return false;
			space.IsReserved = true;
			spaceRepository.Update(space);
			return true;
		}
	}
}
