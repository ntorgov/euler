using System;
using System.Collections.Generic;

namespace euler_0017
{
	/// <summary>
	/// Task 0017
	/// <para> If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.</para>
	/// <para>If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?</para>
	/// <para>NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.</para>
	/// </summary>
	class Program
	{
		private static List<Words> list;
		static void Main(string[] args)
		{
			#region Числа до 10

			list.Add(new Words() { Word = "One", Number = 1 });
			list.Add(new Words() { Word = "Two", Number = 2 });
			list.Add(new Words() { Word = "Three", Number = 3 });
			list.Add(new Words() { Word = "Fore", Number = 4 });
			list.Add(new Words() { Word = "Five", Number = 5 });
			list.Add(new Words() { Word = "Six", Number = 6 });
			list.Add(new Words() { Word = "Seven", Number = 7 });
			list.Add(new Words() { Word = "Eight", Number = 8 });
			list.Add(new Words() { Word = "Nine", Number = 9 });
			list.Add(new Words() { Word = "Ten", Number = 10 });

			list.Add(new Words() { Word = "Elleven", Number = 11 });
			list.Add(new Words() { Word = "Twelve", Number = 12 });

			#endregion

			Console.WriteLine("Hello World!");
		}

		public void Parser(int Number)
		{
			string Value = Number.ToString();
			int Length = Value.Length;
			var digits = 0;
			var tens = 0;
			var hundrets = 0;
			var thousands = 0;

			if (Length >= 1)
			{
				digits = int.Parse(Value.Substring(Length - 1, 1));
			}
			if (Length >= 2)
			{
				tens = int.Parse(Value.Substring(Length - 2, 1));
			}
			if (Length >= 3)
			{
				hundrets = int.Parse(Value.Substring(Length - 3, 1));
			}
			if (Length >= 4)
			{
				thousands = int.Parse(Value.Substring(Length - 4, 1));
			}

			if (tens == 1 && (digits == 1 || digits == 2))
			{
				///
			}
			else
			{
				var digitalWord = "";
				foreach(var word in list)
				{
					if (word.Number == digits)
					{
						digitalWord = word.Word;
					}
				}
			}
		}
	}
}
