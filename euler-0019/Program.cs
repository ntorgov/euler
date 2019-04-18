using System;
using System.Collections.Generic;

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

		/// <summary>
		/// День недели
		/// </summary>
		private static readonly int StartKnownDay = 1;

		/// <summary>
		/// Число
		/// </summary>
		private static readonly int StartKnownDate = 1;

		/// <summary>
		/// Месяц
		/// </summary>
		private static readonly int StartKnownMonth = 1;

		/// <summary>
		/// Год
		/// </summary>
		private static readonly int StartKnownYear = 1900;

		#endregion

		static void Main(string[] args)
		{
			var Year = StartKnownYear;
			var Month = StartKnownMonth;
			var Day = StartKnownDay;
			var Date = StartKnownDate;
			var dayCounter = 0;

			var ResultCounter = 0;

			List<Dates> MemoryEater = new List<Dates>();
			List<Dates> CorrectDates = new List<Dates>();

			while (Year <= 2000 && Month <= 12 && Date <= 31)
			{

				if (Year >= 1901 && Month >= 1 && Date >= 1)
				{
					if (Date == 1 && Day == 7)
					{
						ResultCounter++;
						CorrectDates.Add(new Dates()
						{
							Year = Year,
							Month = Month,
							Date = Date
						});
						Console.WriteLine("Day: " + Day + ", Date: " + Year + "-" + Month + "-" + Date);
					}
				}

				dayCounter++;
				Date++;
				Day++;

				var isLeapYear = IsLeap(Year);

				if ((Date > 31 && (Month == 1 || Month == 3 || Month == 4 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)) ||
					(Date > 29 && isLeapYear && Month == 2) ||
					(Date > 22 && !isLeapYear && Month == 2) ||
					(Date > 30 && (Month == 4 || Month == 6 || Month == 9 || Month == 11)))
				{
					Date = 1;
					Month++;
				}

				if (Month > 12)
				{
					Month = 1;
					Year++;
				}

				if (Day > 7)
				{
					Day = 1;
				}

				MemoryEater.Add(new Dates()
				{
					Year = Year,
					Month = Month,
					Date = Date
				});
			}

			Console.WriteLine("Result is " + ResultCounter);

			Console.ReadLine();
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
