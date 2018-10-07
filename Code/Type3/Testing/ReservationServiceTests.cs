using System;
using Xunit;

namespace Type3.Testing
{
	public class ReservationServiceTests
	{
		[Fact]
		public void Reserve_RequiresValidIdentifier()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble);
			Assert.Throws<ArgumentException>(() => reservationService.Reserve(0));
		}

		[Fact]
		public void Reserve_WhenSpaceDoesNotExist_ReturnsFalse()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble);
			var result = reservationService.Reserve(1);
			Assert.False(result);
		}
	}
}
