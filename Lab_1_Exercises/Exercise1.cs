using System;
using System.Collections.Generic;

namespace Lab_1_Exercises
{
	public class Exercise1
	{
		/// <summary>
		/// Recursive computation of the Fibonacci sequence.
		/// </summary>
		/// <param name="n">How many numbers from the Fibonacci sequence to compute</param>
		/// <returns>each number of the sequence</returns>
		static public int recursiveFibonacci(int n)
		{
			if (n == 1)
				return 1;
			if (n == 0)
				return 0;
			
			return recursiveFibonacci(n-1) + recursiveFibonacci(n - 2);
		}



		static public List<int> intToList(int n, int number)
		{
			List<int> list = new List<int>();
			for (int  i = 0; i < n; i++)
			{
				list.Add(recursiveFibonacci(i));
			}
			return list;
		}


		/// <summary>
		/// Iterative computation of the Fibonacci sequence.
		/// </summary>
		/// <param name="n">How many numbers from the Fibonacci sequence to compute</param>
		/// <returns></returns>
		static public List<int> iterativeFibonacci(int n)
		{
			List<int> seq = new List<int>();
			int newNum = 1, oldNum = 0;
			for (int i = 1; i < n; i++)
			{
				seq.Add(oldNum);
				int temp = newNum;
				newNum += oldNum;
				oldNum = temp;
			}
			seq.Add(oldNum);
			return seq;
		}

		/// <summary>
		/// Printing the Fibonacci sequence computed. If the second parameter is not null, print both side by side.
		/// </summary>
		static public void print(List<int> list1, List<int> list2 = null)
		{
			for (int i = 0; i < list1.Count; i++)
			{
				if (list2 != null)
					Console.WriteLine("\tITERATIVE" + "\t\t" + "RECURSIVE");
				Console.Write(i + ":\t" + list1[i].ToString());
				if (list2 != null)
					Console.Write("\t\t\t" + list2[i].ToString() + "\n");
			}
		}
	}
}
