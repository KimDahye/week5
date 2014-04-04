using System;

namespace week5_lab5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Sausage\tBun\tKetchup\tMustard\tOnions");

			for (int s=0; s<2; s++) {
				for (int b=0; b<2; b++) {
					for (int k = 0; k<2; k++) {
						for (int m = 0; m<2; m++) {
							for (int o = 0; o<2; o++) {
								Console.WriteLine ("{0}\t{1}\t{2}\t{3}\t{4}\t",s,b,k,m,o);
							}
						}
					}
				}
			}
		}
	}
}
