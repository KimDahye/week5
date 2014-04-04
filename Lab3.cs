using System;

namespace week5_lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random random = new Random ();
			int num = random.Next (1, 100);
			int userNum = 0;

			for (int i = 0; i<6; i++) {

				Console.Write ("What's your guess?");
				userNum = int.Parse(Console.ReadLine ());
			
				if (num < userNum) {
					Console.WriteLine ("Too High!!!");
				} else if (num > userNum) {
					Console.WriteLine ("Too Low!!!");
				} else {
					Console.WriteLine ("You got it! Good Job!");
					break;
				}

				if (i == 5) {
					Console.WriteLine ("No more guess. Better luck next time.");
				}
			}

		}
	}
}
