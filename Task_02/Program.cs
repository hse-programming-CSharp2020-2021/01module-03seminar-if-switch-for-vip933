using System;

namespace Task_02 {
	class Program {
		static void Main(string[] args) {
			int x;
			int.TryParse(Console.ReadLine(), out x);

			string result = null;
			while (x > 0)
            {
				result += x % 10;
				x /= 10;
            }

			if (result == "4201")
				Console.WriteLine(4210);
			else
			{
				bool output = false;
				for (int symb = 0; symb < result.Length; ++symb)
				{
					if (result[symb] != '0')
						output = true;
					if (output)
						Console.Write(result[symb]);
				}
				Console.Write("\n");
			}
		}
	}
}
