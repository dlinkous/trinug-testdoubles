using System;
using Xunit;

namespace Type5.Testing
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
		public void Reserve_ReservesExistingSpaceCorrectly_AndReturnsTrue()
		{
			var spaceRepositoryTestDouble = new SpaceRepositoryTestDouble();
			var reservationService = new ReservationService(spaceRepositoryTestDouble);
			const int identifier = 89;
			spaceRepositoryTestDouble.Spaces.Add(identifier, new Space()
			{
				Identifier = identifier,
				Location = 7,
				IsReserved = false
			});
			var result = reservationService.Reserve(identifier);
			Assert.True(spaceRepositoryTestDouble.Spaces[identifier].IsReserved);
			Assert.True(result);
		}
	}
}
