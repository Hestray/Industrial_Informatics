using System;

namespace Lab_1_Exercises {
	public class Exercise4 {
		public static int			choice = -1;
		private static string		str;
		private static double		height;
		private static int			age;

		private static double idealWeightF(double height, int age) => (height - 100 - (height - 150) / 4) + (age - 20) / 4;
		private static double idealWeightM(double height, int age) => (height - 100 - (height - 150) / 2.5) + (age - 20) / 6;

		public static void menu() {
			while (choice != 0) {
				// retrieve age
				do {
					Console.WriteLine("How old are you? (years)\t\t\t" +
										"Type q to exit");
					str = Console.ReadLine();
					if (str.Equals("q") == true) return;
					else if (!int.TryParse(str, out _)) Exercises.inputError("Invalid input. Please make sure you give me a number", true);
				} while (!int.TryParse(str, out age));

				// retrieve height
				do {
					Console.WriteLine("What's your height? (cm)\t\t\t" +
						"Type q to exit");
					str = Console.ReadLine();
					if (str.Equals("q") == true) return;
					else if (!double.TryParse(str, out _)) Exercises.inputError("Invalid input. Please make sure you give me a number", true);
				} while (!double.TryParse(str, out height));

				// retrieve gender
				do {
					Console.WriteLine("What's your gender?");
					Console.WriteLine("1. Female\n" +
										"2. Man\n" +
										"0. Exit");
					str = Console.ReadLine();
					if (!int.TryParse(str, out _)) Exercises.inputError("Invalid input. Please make sure you select a number", true);
				} while (!int.TryParse(str, out choice));

				// print the ideal weight based on gender
				switch (choice) {
					case 0:
						Console.WriteLine("bye bye");
						return;
					case 1:
						print(idealWeightF(height, age));
						break;
					case 2:
						print(idealWeightM(height, age));
						break;
				}
			}
		}

		public static void print(double n) {
			Console.WriteLine("\n\nYour ideal weight should be: " + n.ToString("#.00") + " kg");
			Console.WriteLine("\nPress any key to go back...");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
