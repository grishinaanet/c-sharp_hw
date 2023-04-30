void intersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine("x = " + x);
    double y_f = k1 * x + b1;
    Console.WriteLine("y1 = " + y_f);
    double y_s = k2 * x + b2;
    Console.WriteLine("y2 = " + y_s);
    Console.WriteLine($"({y_f},{y_s})");
}

double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

intersectionPoint(b1, k1, b2, k2);