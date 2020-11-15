using System;
using System.Globalization;

namespace Task_01
{
	class Program
	{
		static void Main()
		{
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

			double x, y;
			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);


			Console.WriteLine(G(x,y));

		}

		public static bool G(double x, double y) {
			bool res = false;

			if (x >= 0 && x * x + y * y <= 4 && x >= y)
				res = true;

			return res;
		}
	}
}
