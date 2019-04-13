namespace euler_0018
{
	class RouteModel
	{
		/// <summary>
		/// Идентификатор маршрута
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Последняя позиция X
		/// </summary>
		public int PositionX { get; set; }

		/// <summary>
		/// Последняя позиция Y
		/// </summary>
		public int PositionY { get; set; }

		/// <summary>
		/// Значение маршрута
		/// </summary>
		public long Value { get; set; }

		/// <summary>
		/// Счетчик жизненного цикла
		/// </summary>
		public int LifeCycle { get; set; }

		public RouteModel()
		{
			Value = 0;
			PositionX = 0;
			PositionY = 0;
			LifeCycle = 0;
			Id = 0;
		}
	}
}
