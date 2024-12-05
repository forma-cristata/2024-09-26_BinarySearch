using System.Diagnostics.Metrics;

// Kaci Craycraft, kcraycraft45 

namespace ModifiedBinarySearch
{
    internal class Program
    {
        public static int counter = 0;
        public static void Main()
        {
            for(int j = 0; j < 11; j++)
            {
                counter = 0;
                Console.WriteLine($"{j}. ");
                Random rand = new Random();
                int x = rand.Next(1, 100);
                int[] testingArray = new int[x];
                for(int i = 0; i < x; i++)
                {
                    testingArray[i] = i;
                }
                String arrayString = String.Join(", ", testingArray);
                int y = rand.Next(0, x);
                Console.WriteLine($"Searching for item {y} in array: {(arrayString).Substring(0, arrayString.Length-2)}");
                int index = BinarySearch(testingArray, y);
                double predictedSteps = Math.Floor(Math.Log(x, 2.0) + 1); // Worst Case O(n) = log2(10);
                Console.WriteLine($"Worst Case Steps: {predictedSteps}, Actual Steps: {counter}");
                Console.WriteLine($"Index: {index}\n\n");
            }
        }

        public static int BinarySearch(int[] ar, int v)
        {
            int l = 0;
            int r = ar.Length - 1;
            while(l < r)
            {
                counter++;
                int m = l + (r - l) / 2;
                int c = ar[m] - v;
                if(c == 0)
                {
                    l = m;
                    break;
                }
                else if (c < 0)
                {
                    l = m + 1; 
                }
                else
                {
                    r = m - 1;
                }
            }
            return l;
        }
    }
}
