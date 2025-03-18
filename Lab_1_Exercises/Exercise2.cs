
using System;

namespace Lab_1_Exercises
{
	internal class Exercise2
	{
		public static double[]	numbers = new double[2];
		private static double?	results;
		
		// operations
		public static double add(double a, double b) => a + b;
		public static double subtract(double a, double b) => a - b;
		public static double multiply(double a, double b) => a * b;
		public static double divide(double a, double b) => a != 0 ? a / b : throw new DivideByZeroException("Division by zero is no bueno, brother");


		// menu and print
		public static void menu()
		{
			int choice = -1;
			
			while (choice != 0)
			{
				label_a:
				Console.WriteLine("Please give me two numbers: ");
			
				Console.Write("a = ");
				string a = Console.ReadLine();
				if (double.TryParse(a, out double _)) {
					numbers[0] = double.Parse(a);
					
					label_b:
					Console.Write("\nb = ");
					string b = Console.ReadLine();
					if (double.TryParse(b, out double _))
						numbers[1] = double.Parse(b);
					else {
						Exercises.inputError("Variable must be a number!", false);
						goto label_b;
					}
				} else {
					Exercises.inputError("Variable must be a number!", false);
					goto label_a;
				}

				Console.WriteLine("Now please choose an operation: ");
				Console.WriteLine("1. Add\n" +
									"2. Subtract\n" +
									"3. Multiply\n" +
									"4. divide\n" +
									"0. exit");
				choice = int.Parse(Console.ReadLine());
				switch(choice) {
					case 0:
						Console.WriteLine("goodbye!"); 
						return;
					case 1: 
						results = add(numbers[0], numbers[1]);
						break;
					case 2:
						results = subtract(numbers[0], numbers[1]);
						break;
					case 3:
						results = multiply(numbers[0], numbers[1]);
						break;
					case 4:
						if (numbers[0] == 0) {
							Exercises.inputError("Division by zero is no bueno, brother", true);
							goto label_a;
						}
						results = divide(numbers[0], numbers[1]);
						break;
					default: 
						Exercises.inputError("Invalid choice", true);
						break;
				};

				if (results != null)
				print(results.Value);
			}
		}


		public static void print(double n)
		{
			Console.WriteLine("Your results: " + n);
			Console.WriteLine("\nPress any key to go back...");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
