using System;

namespace Type2
{
	public class ReservationService
	{
		private readonly ISpaceRepository spaceRepository;
		private readonly ISettingsProvider settingsProvider;

		public ReservationService(ISpaceRepository spaceRepository, ISettingsProvider settingsProvider)
		{
			this.spaceRepository = spaceRepository;
			this.settingsProvider = settingsProvider;
		}

		public bool Reserve(int identifier)
		{
			if (identifier <= 0) throw new ArgumentException(nameof(identifier));
			if (!settingsProvider.ReservationsAllowed) return false;
			throw new NotImplementedException();
		}
	}
}
