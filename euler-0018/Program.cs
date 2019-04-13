using System;

namespace euler_0018
{
	/// <summary>
	/// <para>Начиная в вершине треугольника (см. пример ниже) и перемещаясь вниз на смежные числа, максимальная сумма до основания составляет 23.</para>
	/// <example>
	///    3
	///   7 4
	///  2 4 6
	/// 8 5 9 3
	/// </example>
	///<para>То есть, 3 + 7 + 4 + 9 = 23.</para>
	///<para>Найдите максимальную сумму пути от вершины до основания следующего треугольника:</para>
	///<para>
	///                            75
	///                          95  64
	///                        17  47  82
	///                      18  35  87  10
	///                    20  04  82  47  65
	///                  19  01  23  75  03  34
	///                88  02  77  73  07  63  67
	///              99  65  04  28  06  16  70  92
	///            41  41  26  56  83  40  80  70  33
	///          41  48  72  33  47  32  37  16  94  29
	///        53  71  44  65  25  43  91  52  97  51  14
	///      70  11  33  28  77  73  17  78  39  68  17  57
	///    91  71  52  38  17  14  91  43  58  50  27  29  48
	///  63  66  04  68  89  53  67  30  73  16  69  87  40  31
	///04  62  98  27  23  09  70  98  73  93  38  53  60  04  23
	///</para>
	///<para>Примечание: Так как в данном треугольнике всего 16384 возможных маршрута от вершины до основания, эту задачу можно решить проверяя каждый из маршрутов.</para>
	/// </summary>
	class Program
	{
		private static int[,] DataArray;
		static void Main(string[] args)
		{
			DataArray = new int[,] {
				{3, 0, 0, 0},
				{7, 4, 0, 0},
				{2, 4, 6, 0},
				{8, 5, 9, 4}
			};

			var Result = 0;


			for (var y = DataArray.GetLength(1) - 1; y >= 0; y--)
			{
				var maxRowValue = 0;
				for (var x = 0; x <= DataArray.GetLength(0) - 1; x++)
				{
					var nearestRight = x;
					var nearestLeft = x - 1;

					maxRowValue = Math.Max(maxRowValue, DataArray[y, x]);
				}
				Console.WriteLine("Line: " + y + ", value: " + maxRowValue);
			}

			Console.WriteLine("Hello World!");
		}
	}
}
