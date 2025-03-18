using System;

namespace Lab_1_Exercises {
	public class Exercise5 {
		public static string input;
		private static int[] seq = new int[1];
		
		private static double arithAvg() => sumProd(0) / seq.Length;

		private static double geomAvg() => Math.Pow(sumProd(1), 1/seq.Length);

		/// <summary>
		/// Computes the sum or the product of the sequence
		/// </summary>
		/// <param name="operation">is "0" for sum and "1" for product</param>
		/// <returns></returns>
		private static int sumProd(int operation) {
			for (int i = 0; i < seq.Length; i++)
				if (operation == 0) operation += seq[i];
				else				operation *= seq[i];
			return operation;
		}

		public static void menu() {
			// retrieve sequence
			Console.WriteLine("Please give me a sequence of whole numbers: \t\t\tPress b to exit. Press c to continue.");
			int n = Convert.ToInt32(Console.ReadLine());

			seq = new int[n];

			Console.WriteLine("Please enter each number in your sequence:");
			for (int i = 0; i < n; i++) {
				while (true) {
					Console.Write($"Number {i + 1}: ");
					if (int.TryParse(Console.ReadLine(), out int number)) {
						seq[i] = number;
						break;
					} else {
						Console.WriteLine("Invalid input. Please enter a whole number.");
					}
				}
			}

			// compute and print average
			Console.WriteLine("Arithmetic average: " + arithAvg() + "\nGeometric average: " + geomAvg());
		}
	}
}
