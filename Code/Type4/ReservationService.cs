using System;

namespace Type4
{
	public class ReservationService
	{
		private readonly ISpaceRepository spaceRepository;
		private readonly INotifier notifier;

		public ReservationService(ISpaceRepository spaceRepository, INotifier notifier)
		{
			this.spaceRepository = spaceRepository;
			this.notifier = notifier;
		}

		public bool Reserve(int identifier)
		{
			if (identifier <= 0) throw new ArgumentException(nameof(identifier));
			var space = spaceRepository.Read(identifier);
			if (space == null) return false;
			space.IsReserved = true;
			spaceRepository.Update(space);
			notifier.NotifyReservation(identifier);
			return true;
		}
	}
}
