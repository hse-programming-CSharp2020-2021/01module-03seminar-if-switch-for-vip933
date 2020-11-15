using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace Task_06 {
	class Program {

		static void Main(string[] args) 
		{
			int answer;
			List<int> numbers = GetNumbers();
			List<int> mins = new List<int>();

			int min = 100, number;
			for (int aud = 0; aud < numbers.Count(); ++aud)
            {
				number = numbers[aud] - numbers[aud] / 100 * 100;
				if (number < min) min = number;
			}

			for (int aud = 0; aud < numbers.Count(); ++aud)
            {
				number = numbers[aud] - numbers[aud] / 100 * 100;
				if (number == min) mins.Add(numbers[aud]);
			}

			int minLev = 10;
			for (int aud = 0; aud < mins.Count(); ++aud)
				if (mins[aud] / 100 < minLev) 
					minLev = mins[aud] / 100;

            Console.WriteLine(minLev*100+min);
		}

		public static List<int> GetNumbers() {
			return Console.ReadLine().Split(' ').ToList().ConvertAll((x) => int.Parse(x));
		}
	}
}
