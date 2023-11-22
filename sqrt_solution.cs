internal class sqrt_solution
{
    public static void discr(double a, double b, double c)
    {
        double temp = b * b - 4 * a * c;
        double x1,x2;
        switch (temp)
            { 
                case (> 0):
                    { 
                        Console.WriteLine("2 solutions");
                        x1 = (-b + Math.Sqrt(temp)) / 2 * a;
                        x2 = (-b - Math.Sqrt(temp)) / 2 * a;
                        Console.WriteLine("2 solutions:, {0:F2},{1:F2}", x1,x2);
                        break;
                    }
                case (== 0.0):
                    { 
                    Console.WriteLine("1 solution");
                    x1 = (-b  / 2 * a);
                    Console.WriteLine("1 solution:, {0:F2}", x1);
                    }
                break;
                case (< 0):
                    Console.WriteLine("no solutions"); break;
            }


    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a,b,c coefficients:");
        Console.Write("a (not a zero!) = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());


    }
}