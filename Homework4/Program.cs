namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            var students = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                students[i] = Student.CreateStudentFromInput();
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            
            int[,] grid = new int[,]
            {
                {1, 1, 1, 2, 2},
                {1, 1, 0, 2, 2},
                {1, 0, 0, 2, 2},
                {2, 2, 2, 2, 2}
            };
            int startX = 1;
            int startY = 1;
            int newValue = 9;

            static void ChangingGridWithNewValueWithItsNeighbors(int[,] grid, int startX, int startY, int newValue)
            {
                // Get the old value at the starting coordinates
                int oldValue = grid[startX, startY];

                // If oldValue is the same as newValue, no need to proceed
                if (oldValue == newValue)
                {
                    return;
                }

                // Change the starting cell
                grid[startX, startY] = newValue;

                bool changed = true;
                int rows = grid.GetLength(0); // Number of rows
                int cols = grid.GetLength(1); // Number of columns

                while (changed)
                {
                    changed = false;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (grid[i, j] == oldValue && HasNewValueNeighbor(grid, i, j, newValue))
                            {
                                grid[i, j] = newValue; // Change to new value
                                changed = true; // Mark that a change has occurred
                            } 
                        }
                    }
                }
            }

            static bool HasNewValueNeighbor(int[,] grid, int x, int y, int newValue)
            {
                int rows = grid.GetLength(0); // Number of rows
                int cols = grid.GetLength(1); // Number of columns

                if (x > 0 && grid[x - 1, y] == newValue) return true;
                if (x < rows - 1 && grid[x + 1, y] == newValue) return true;
                if (y > 0 && grid[x, y - 1] == newValue) return true;
                if (y < cols - 1 && grid[x, y + 1] == newValue) return true;

                return false;
            }

            static void ChangeWithNewValueRecursive(int[,] grid, int x, int y, int oldValue, int newValue)
            {
                // Matrix bounds check
                if (x < 0 || y < 0 || x >= grid.GetLength(0) || y >= grid.GetLength(1))
                    return;

                // If cell is not oldValue, do nothing
                if (grid[x, y] != oldValue)
                {
                    return;
                }

                // Replace
                grid[x, y] = newValue;

                // Recursive calls
                ChangeWithNewValueRecursive(grid, x + 1, y, oldValue, newValue); // down
                ChangeWithNewValueRecursive(grid, x - 1, y, oldValue, newValue); // up
                ChangeWithNewValueRecursive(grid, x, y + 1, oldValue, newValue); // right
                ChangeWithNewValueRecursive(grid, x, y - 1, oldValue, newValue); // left
            }

            ChangingGridWithNewValueWithItsNeighbors(grid, startX, startY, newValue);
            Console.WriteLine("Grid after non-recursive change:");
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
            newValue -= 1; // Change newValue to see different result
            ChangeWithNewValueRecursive(grid, startX, startY, grid[startX, startY], newValue);
            Console.WriteLine("Grid after recursive change:");
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
