int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int itog = 0;

for (int i = 0; i < 32; i++)
{
    int count = 0;
    if ((num1 & (1 << i)) != 0) count++;
    if ((num2 & (1 << i)) != 0) count++;
    if ((num3 & (1 << i)) != 0) count++;

    if (count >= 2)
    {
        itog |= (1 << i);
    }
}

Console.WriteLine(itog);
