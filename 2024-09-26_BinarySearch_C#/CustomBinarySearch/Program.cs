using System;
using System.Linq;

namespace CustomBinarySearch
{
	public class Program
	{
		private const uint ARRAY_SIZE = 16;

		//DO NOT MODIFY THE MAIN METHOD
		public static void Main()
		{
			Random rand = new Random();
			int[] randNums = new int[ARRAY_SIZE];

			for (int i = 0; i < randNums.Length; i++)
			{
				int randNum = rand.Next(0, 100);

				while (randNums.Contains(randNum))
				{
					randNum = rand.Next(0, 100);
				}

				randNums[i] = randNum;
			}

			Array.Sort(randNums);

			Console.WriteLine($"Numbers generated {String.Join(", ", randNums)}");
			Console.Write("Enter a number to search for: ");
			int searchNum = int.Parse(Console.ReadLine()!);

			int index = Source.BinarySearch(randNums, searchNum);

			if(index != -1)
			{
				Console.WriteLine($"Number found at index {index}");
                if (randNums[index] != searchNum)
                {
					PrintIncorrectMsg();
                }
				else
				{
					PrintCorrectMsg();
                }
            }
			else
			{
				Console.WriteLine("Number not found");
				if(randNums.Contains(searchNum))
				{
					PrintIncorrectMsg();
                }
				else
				{
					PrintCorrectMsg();
                }
			}
		}

		private static void PrintIncorrectMsg()
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("BinarySearch method is not implemented correctly");
            Console.ResetColor();
        }

		private static void PrintCorrectMsg()
		{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This result is correct");
            Console.ResetColor();
        }
	}
}