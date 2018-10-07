using System;
using Xunit;

namespace Type2.Testing
{
	public class ReservationServiceTests
	{
		[Fact]
		public void Reserve_RequiresValidIdentifier()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var settingsProviderTestDouble = new SettingsProviderTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble, settingsProviderTestDouble);
			Assert.Throws<ArgumentException>(() => reservationService.Reserve(0));
		}

		[Fact]
		public void Reserve_WhenReservationsDisallowed_ReturnsFalse()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var settingsProviderTestDouble = new SettingsProviderTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble, settingsProviderTestDouble);
			var result = reservationService.Reserve(1);
			Assert.False(result);
		}
	}
}
