namespace Homework2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //Number 1
            int MinimumInArray(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++) 
                {
                    if (arr[i] < min) // Check for minimum value
                    {
                        min = arr[i];
                    }
                }
                return min;
            }

            int MaximumInArray(int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max) // Check for maximum value
                    {
                        max = arr[i];
                    }
                }
                return max;
            }

            int n1 = 20;
            Random random1 = new Random(); // Random number generator
            int[] array1 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                array1[i] = random1.Next(1, 101); // Arrays with values from 1 to 100 randomly
            }
            
            foreach (var item in array1)
            {
                Console.Write(item + " "); // Print the array
            }

            Console.WriteLine("\nMinimum value in the array: " + MinimumInArray(array1));
            Console.WriteLine("Maximum value in the array: " + MaximumInArray(array1));
            Console.WriteLine();

            //Number 2
            int[] CountArray(int[] arr)
            {
                int size = MaximumInArray(arr) + 1; // Size of the new array
                int[] countArr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    countArr[arr[i]]++; // Increment the count for the number at index arr[i]
                }
                return countArr;
            }

            int n2 = 15;
            int[] array2 = new int[n2];
            Random random2 = new Random(); // Random number generator

            for (int i = 0; i < n2; i++)
            {
                array2[i] = random2.Next(1, 21); // Arrays with values from 1 to 20 randomly
            }

            foreach (var item in array2)
            {
                Console.Write(item + " "); // Print the array
            }

            int[] newArr2 = CountArray(array2);
            Console.WriteLine("\nCount Array: ");
            for(int i = 0; i < newArr2.Length; i++)
            {
                if (newArr2[i] > 0)
                {
                    Console.WriteLine("Number " + i + " occurs " + newArr2[i] + " times.");
                }
            }

            Console.WriteLine();

            //Number 3

            int SecondaryDiagonalSum(int[,] matrix, int n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, n - 1 - i]; // Summing the secondary diagonal elements
                }
                return sum;
            }

            int DiagonalSum(int[,] matrix, int n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += matrix[i, i]; // Summing the main diagonal elements
                }
                return sum;
            }

            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " "); // Print the matrix
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe sum of the main diagonal is: " + DiagonalSum(matrix, 3));
            Console.WriteLine("The sum of the secondary diagonal is: " + SecondaryDiagonalSum(matrix, 3));
            Console.WriteLine("The ratio of the sums is: " + (double)DiagonalSum(matrix, 3) / SecondaryDiagonalSum(matrix, 3));
            Console.WriteLine();

            //Number 4
            int SumBelowSecondaryDiagonal(int[,] matrix, int n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i + j > n - 1) // Condition to check if the element is below the secondary diagonal
                        {
                            sum += matrix[i, j];
                        }
                    }
                }
                return sum;
            }
            int[,] matrix4 = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            for(int i = 0; i < matrix4.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4.GetLength(1); j++)
                {
                    Console.Write(matrix4[i, j] + " "); // Print the matrix
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe sum of elements below the secondary diagonal is: " + SumBelowSecondaryDiagonal(matrix4, 4));
            Console.WriteLine();

            //Number 5
            int SumOfNeighbors(int[,] matrix, int i, int j)
            {
                int sum = 0;
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        if (x == 0 && y == 0) continue; // Skip the element itself
                        int newRow = i + x;
                        int newCol = j + y;
                        // Check if the neighbor is within bounds
                        if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
                        {
                            sum += matrix[newRow, newCol];
                        }
                    }
                }
                return sum;
            }

            int[] FindTheNeighbors(int[,] matrix, int i, int j)
            {
                List<int> neighbors = new List<int>();
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        if (x == 0 && y == 0) continue; // Skip the element itself
                        int newRow = i + x;
                        int newCol = j + y;
                        // Check if the neighbor is within bounds
                        if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
                        {
                            neighbors.Add(matrix[newRow, newCol]);
                        }
                    }
                }
                return neighbors.ToArray();
            }

            int[,] matrix5 = {
                { 1, 2, 3, 6, 8 },
                { 4, 5, 6, 9, 12 },
                { 7, 8, 9, 18, 7 },
                { 14, 5, 26, 9, 2 }
            };
            int rowIndex = 2;
            int colIndex = 3;

            for(int i = 0; i < matrix5.GetLength(0); i++)
            {
                for (int j = 0; j < matrix5.GetLength(1); j++)
                {
                    Console.Write(matrix5[i, j] + " "); // Print the matrix
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe sum of neighbors is: " + SumOfNeighbors(matrix5, rowIndex, colIndex));
            Console.WriteLine("The neighbors are: ");
            foreach (var neighbor in FindTheNeighbors(matrix5, rowIndex, colIndex))
            {
                Console.Write(neighbor + " ");
            }

        }
    }
}
