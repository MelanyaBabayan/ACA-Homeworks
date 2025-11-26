using System;

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x = 0, int y = 0)
    {
        X = x; Y = y;
    }
    public static Point[] GenerateRandomPoints(int size, int from = 0, int to = 10)
    {
        Random rand = new Random();
        Point[] points = new Point[size];

        for (int i = 0; i < size; i++)
        {
            points[i] = new Point
            {
                X = rand.Next(from, to + 1),
                Y = rand.Next(from, to + 1)
            };
        }
        return points;
    }
    public static void SortPoints(ref Point[] points)
    {
        for (int i = 0; i < points.Length - 1; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                if (points[i].X > points[j].X || (points[i].X == points[j].X && points[i].Y > points[j].Y))
                {
                    Point temp = points[i];
                    points[i] = points[j];
                    points[j] = temp;
                }
            }
        }
    }
    public static void PrintArray(Point[] points)
    {
        foreach (var point in points)
        {
            Console.WriteLine(point);
        }
    }
    public override string ToString()
    {
        return $"( {X}, {Y} )";
    }
};
