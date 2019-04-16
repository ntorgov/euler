using System;

namespace euler_0019
{
	/// <summary>
	/// <list type="bullet">
	/// <listheader><term>Дана следующая информация</term><description>(однако, вы можете проверить ее самостоятельно):</description></listheader>
	/// <item><description>1 января 1900 года - понедельник.</description></item>
	/// <item><description>В апреле, июне, сентябре и ноябре 30 дней.</description></item>
	/// <item><description>В феврале 28 дней, в високосный год - 29.</description></item>
	/// <item><description>В остальных месяцах по 31 дню.</description></item>
	/// <item><description>Високосный год - любой год, делящийся нацело на 4, однако последний год века (ХХ00) является високосным в том и только том случае, если делится на 400.</description></item>
	/// </list>
	/// <para>Сколько воскресений выпадает на первое число месяца в двадцатом веке (с 1 января 1901 года до 31 декабря 2000 года)?</para>
	/// </summary>
	class Program
	{
		#region Known date

		private static readonly int StartKnownDay = 1;
		private static readonly int StartKnownDate = 1;
		private static readonly int StartKnownMonth = 1;
		private static readonly int StartKnownYear = 1900;

		#endregion

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		static bool IsLeap(int Year)
		{
			var result = false;

			if (Year % 4 == 0)
			{
				result = true;
			}
			if (Year % 100 == 0 && Year % 400 == 0)
			{
				result = true;
			}

			return result;
		}
	}
}
