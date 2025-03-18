using System;

namespace Lab_1_Exercises {
	public class Exercise3 {
		public static int		choice = -1;
		private static string	str;

		private static double FToC(double F) => (F - 32) * 5 / 9;

		private static double CToF(double C) => C * 9 / 5 + 32;

		public static void menu() {
			while (choice != 0) {
				Console.WriteLine("Which conversion do you want to do?");
				Console.WriteLine(	"1. Fahrenheit to Celsius\n" +
									"2. Celsius to Fahrenheit\n" +
									"0. Exit");
				str = Console.ReadLine();
				if (!int.TryParse(str, out choice)) Exercises.inputError("Invalid input. Please make sure you select a number", true); 
				else {
					switch(choice) {
						case 0: 
							Console.Clear();
							Console.WriteLine("bye bye");
							return;
						case 1: 
							Console.Clear();
							do {
								Console.WriteLine("Please give me a temperature in Fahrenheit: ");
								str = Console.ReadLine();
								if (!double.TryParse(str, out double F)) Exercises.inputError("Invalid input. Please make sure you give me a number", true);
								else print(FToC(F));
							} while (!double.TryParse(str, out double _));
							break;
						case 2: 
							Console.Clear();
							do {
								Console.WriteLine("Please give me a temperature in Celsius: ");
								str = Console.ReadLine();
								if (!double.TryParse(str, out double C)) Exercises.inputError("Invalid input. Please make sure you give me a number", true);
								else print(CToF(C));
							} while (!double.TryParse(str, out double _));
							break;
						default: 
							Exercises.inputError("Invalid input. Please make sure you select a number", true); 
							break;
					}
				}
			}
		}

		public static void print(double n) {
			Console.WriteLine("Your results: " + n.ToString("#.00"));
			Console.WriteLine("\nPress any key to go back...");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
