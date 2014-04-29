using System;

namespace week5_lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			do {
				Console.Write ("Enter the operaton[+,-, *, /](If you want to quit, enter 'q'): ");
				string operation = Console.ReadLine ();

				if (operation == "q") {
					Console.WriteLine ("Bye!");
					break;
				}

				if ((operation != "+") && (operation != "-") && (operation != "*") && (operation != "/")){
					Console.WriteLine ("You entered {0}. Only +,-,*,/,q are allowed.", operation);
					Console.WriteLine ();
					continue;
				}

				Console.Write ("Enter the first number : ");
				int num1 = int.Parse (Console.ReadLine ());  
				Console.Write ("Enter the second number : ");
				int num2 = int.Parse (Console.ReadLine ());

				switch (operation) {
				case "+":
					Console.WriteLine ("{0}+{1} = {2}", num1, num2, num1 + num2);
					Console.WriteLine ();
					break;
				case "-":
					Console.WriteLine ("{0}-{1} = {2}", num1, num2, num1 - num2);
					Console.WriteLine ();
					break;
				case "*":
					Console.WriteLine ("{0}*{1} = {2}", num1, num2, num1 * num2);
					Console.WriteLine ();
					break;
				case "/":
					Console.WriteLine ("{0}/{1} = {2}", num1, num2, num1 / num2);
					Console.WriteLine ();
					break;
				}
			} while(true) ;
		}
	}
}
