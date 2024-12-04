int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
double k1, k2;

if (a == 0)
{
    if (b == 0)
    {
        if (c == 0)
        {
            Console.WriteLine("Бесконечное количество решений");
        }
        else
        {
            Console.WriteLine("Нет решений");
        }
    }
    else
    {
        k1 = -c / (double)b;
        Console.WriteLine($"Линейное уравнение, 1 корень: {k1}");
    }
}
else
{
    double d = (b * b) - (4 * a * c);
    if (d > 0)
    {
        k1 = (-b + Math.Sqrt(d)) / (2 * a);
        k2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"2 корня: {k1} и {k2}");
    }
    else if (d < 0)
    {
        Console.WriteLine("Нет действительных корней");
    }
    else
    {
        k1 = -b / (2 * a);
        Console.WriteLine($"1 корень: {k1}");
    }
}