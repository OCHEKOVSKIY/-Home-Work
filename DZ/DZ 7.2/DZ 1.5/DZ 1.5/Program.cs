int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());

int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int c2 = Convert.ToInt32(Console.ReadLine());

double[] triangle1 = { a1, b1, c1 };
double[] triangle2 = { a2, b2, c2 };

Array.Sort(triangle1);
Array.Sort(triangle2);

double ratio1 = triangle1[0] / triangle2[0];
double ratio2 = triangle1[1] / triangle2[1];
double ratio3 = triangle1[2] / triangle2[2];


Console.WriteLine($"{ratio1}, {ratio2}, {ratio3}");
if (ratio1 == ratio2 && ratio2 == ratio3)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}