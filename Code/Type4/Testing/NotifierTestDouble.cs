using System;
using System.Collections.Generic;

namespace Type4.Testing
{
	internal class NotifierTestDouble : INotifier
	{
		internal List<int> NotifyReservationCalls { get; } = new List<int>();

		public void NotifyReservation(int identifier) =>
			NotifyReservationCalls.Add(identifier);
	}
}
