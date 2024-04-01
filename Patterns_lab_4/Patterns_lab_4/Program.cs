using Patterns_lab_4;

int userSelect; 

do
{
    Console.WriteLine("Enter '0' if you want to work with HalfPlane and '1' - with HalfSpace");
    userSelect = Convert.ToInt32(Console.ReadLine());
    if (userSelect == 0)
    {
        Console.WriteLine("Enter coefficients for the HalfPlane (a1, a2, b):");
        Console.WriteLine("Enter a1");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a2");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = Convert.ToDouble(Console.ReadLine());
        HalfPlane baseObj = HalfFactory.CreateHalf(false, a1, a2, 0, b);

        Console.WriteLine("Enter coordinates for the point (x1, x2):");
        Console.WriteLine("Enter x1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter x2");
        double x2 = Convert.ToDouble(Console.ReadLine());

        bool pointInHalfPlane = baseObj.IsPointInHalfPlane(x1, x2);
        Console.WriteLine($"The point ({x1}, {x2}) {(pointInHalfPlane ? "belongs to" : "does not belong to")} the half plane.");
        baseObj.PrintCoefficients();
    }
    else if (userSelect == 1)
    {
        Console.WriteLine("Enter coefficients for the HalfSpace (a1, a2, a3, b):");
        Console.WriteLine("Enter a1");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a2");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a3");
        double a3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = Convert.ToDouble(Console.ReadLine());
        HalfPlane baseObj = HalfFactory.CreateHalf(true, a1, a2, a3, b);

        Console.WriteLine("Enter coordinates for the point (x1, x2, x3):");
        Console.WriteLine("Enter x1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter x2");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter x3");
        double x3 = Convert.ToDouble(Console.ReadLine());

        bool pointInHalfSpace = ((HalfSpace)baseObj).IsPointInHalfSpace(x1, x2, x3);
        Console.WriteLine($"The point ({x1}, {x2}, {x3}) {(pointInHalfSpace ? "belongs to" : "does not belong to")} the half space.");
        baseObj.PrintCoefficients();
    }
    else
    {
        return;
    }
} while (true);

