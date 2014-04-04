using System;

namespace week5_lab2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 1; i < 10; i++) {
				Console.WriteLine ("[{0} times table]", i);
				for (int j = 1; j<10; j++) {
					Console.WriteLine ("{0}*{1}={2}", i, j, i * j);
				}
				Console.WriteLine ();
			}

		}
	}
}
