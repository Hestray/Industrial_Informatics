using System;

namespace Lab_1_Exercises
{
	internal class Exercises {
		public static void General() {
			Console.Clear();
			Console.WriteLine("Please choose an exercise to visualize: ");
			Console.WriteLine(	"1. Exercise 1\n" +
								"2. Exercise 2\n" +
								"3. Exercise 3\n" +
								"4. Exercise 4\n" +
								"5. Exercise 5\n" +
								"0. Exit");
			if(int.TryParse(Console.ReadLine(), out int choice)) {
				switch (choice)	{
					case 0:
						Console.Clear();
						Console.WriteLine("bye bye");
						Environment.Exit(0);
						break;
					case 1:
						// exercise 1
						Console.Clear();
						Console.WriteLine("Exercise 1");
						int n = 10;
						Exercise1.print(Exercise1.iterativeFibonacci(n),
							Exercise1.intToList(n, Exercise1.recursiveFibonacci(n)));
						returnCmd();
						break;
					case 2:
						// exercise 2
						Console.Clear();
						Console.WriteLine("Exercise 2");
						Exercise2.menu();
						returnCmd();
						break;
					case 3:
						// exercise 3
						Console.Clear();
						Console.WriteLine("Exercise 3");
						Exercise3.menu();
						Exercise3.choice = -1;
						returnCmd();
						break;
					case 4:
						// exercise 4
						Console.Clear();
						Console.WriteLine("Exercise 4");
						Exercise4.menu();
						Exercise4.choice = -1;
						returnCmd();
						break;
					case 5:
						// exercise 5
						Console.Clear();
						Console.WriteLine("Exercise 5");
						Exercise5.menu();
						Exercise5.input = null;
						returnCmd();
						break;
					default:
						inputError("Invalid Choice", true);
						break;
				}
			} else { Console.Clear(); Console.WriteLine("Invalid input"); returnCmd(); }
		}

		private static void returnCmd()	{
			Console.WriteLine("Press any key to go back to the starting menu...");
			Console.ReadKey();
		}

		public static void inputError(string message, Boolean flush) {
			Console.WriteLine(message);
			if (flush) {
				Console.WriteLine("Press any key to go back...");
				Console.ReadKey();
				Console.Clear();
			}
		}
	}
}
