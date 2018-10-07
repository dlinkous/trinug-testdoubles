using System;
using System.Linq;
using Xunit;

namespace Type4.Testing
{
	public class ReservationServiceTests
	{
		[Fact]
		public void Reserve_RequiresValidIdentifier()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var notifierTestDouble = new NotifierTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble, notifierTestDouble);
			Assert.Throws<ArgumentException>(() => reservationService.Reserve(0));
		}

		[Fact]
		public void Reserve_WhenSpaceDoesNotExist_ReturnsFalse()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var notifierTestDouble = new NotifierTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble, notifierTestDouble);
			var result = reservationService.Reserve(1);
			Assert.False(result);
		}

		[Fact]
		public void Reserve_NotifiesCorrectly()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var notifierTestDouble = new NotifierTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble, notifierTestDouble);
			const int identifier = 999;
			var result = reservationService.Reserve(identifier);
			var notification = notifierTestDouble.NotifyReservationCalls.Single();
			Assert.Equal(identifier, notification);
		}
	}
}
