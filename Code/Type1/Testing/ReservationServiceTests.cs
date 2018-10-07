using System;
using Xunit;

namespace Type1.Testing
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
	}
}
