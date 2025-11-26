using System.Text;
using System;

namespace Homework3
{
    internal class Program
    {
         static void Main(string[] args)
         {
                //Number 1

              string JoinArrayWithSeparator(int[] numbers, char separator)
              {
                  StringBuilder st = new StringBuilder(numbers.Length * 2 - 1);

                  for (int i = 0; i < numbers.Length; i++)
                  {
                        st.Append(numbers[i]);
                        if (i < numbers.Length - 1)
                        {
                            st.Append(separator);
                        }
                  }

                  return st.ToString();
              }

                int[] array = { 1, 2, 3, 4, 5 };
                Console.WriteLine(JoinArrayWithSeparator(array, ','));

                //Number 2

                string RepeatPattern(string pattern, int n)
                {
                    StringBuilder sb = new StringBuilder(n * pattern.Length);

                    for (int i = 0; i < n; i++)
                    {
                        sb.Append(pattern);
                    }

                    return sb.ToString();
                }

                Console.WriteLine(RepeatPattern("Hello", 5));

                //Number 3

                Rectangle rect = new Rectangle(5, 10);
                Triangle tri = new Triangle(5, 10);
                Console.WriteLine("Rectangle Area: " + rect.Area());
                Console.WriteLine("Triangle Area: " + tri.Area());

                //Number 4
                var points = Point.GenerateRandomPoints(10, -5, 5);
                Point.PrintArray(points);

                Point.SortPoints(ref points);

                Console.WriteLine("After sorting");
                Point.PrintArray(points);

         }
    }
}
