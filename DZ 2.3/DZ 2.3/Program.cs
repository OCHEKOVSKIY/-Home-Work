
double x = Convert.ToDouble(Console.ReadLine());
while (x < -1 || x > 1)
{
    Console.WriteLine("x не соответствует допустимому диапазону. Введите новое значение");
    x = Convert.ToDouble(Console.ReadLine());
}

double result = 1;
double slog = 1;
int n = 1;

while (Math.Abs(slog) >= 1e-6)
{
    slog *= x / n;
    result += slog;
    n++;
}

// Вывод результата
Console.WriteLine(result);