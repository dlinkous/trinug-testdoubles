using System;

namespace Type1
{
	public class ReservationService
	{
		private readonly ISpaceRepository spaceRepository;

		public ReservationService(ISpaceRepository spaceRepository)
		{
			this.spaceRepository = spaceRepository;
		}

		public void Reserve(int identifier)
		{
			if (identifier <= 0) throw new ArgumentException(nameof(identifier));
			throw new NotImplementedException();
		}
	}
}
