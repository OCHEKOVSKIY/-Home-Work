
class Program
{
    static string ToBinary(int value, int bits)
    {
        if (value >= 0)
        {
            return Convert.ToString(value, 2).PadLeft(bits, '0');
        }
        else
        {
            return Convert.ToString((1 << bits) + value, 2).PadLeft(bits, '0');
        }
    }

    static string AddBinary(string bin1, string bin2)
    {
        int carry = 0;
        string result = "";

        for (int i = bin1.Length - 1; i >= 0; i--)
        {
            int bit1 = bin1[i] - '0';
            int bit2 = bin2[i] - '0';
            int sum = bit1 + bit2 + carry;

            result = (sum % 2) + result;
            carry = sum / 2;
        }

        if (carry > 0)
        {
            result = "1" + result;
        }

        return result.TrimStart('0');
    }

    static int BinaryToDecimal(string bin, int bits)
    {
        int result = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            if (bin[i] == '1')
            {
                result += (1 << (bin.Length - i - 1));
            }
        }

        if (bin[0] == '1')
        {
            result -= (1 << bits);
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        int bits = 20;

        string bin1 = ToBinary(num1, bits);
        string bin2 = ToBinary(num2, bits);

        Console.WriteLine($"\nПервое число в двоичном виде: {bin1}");
        Console.WriteLine($"Второе число в двоичном виде: {bin2}");

        string sumBin = AddBinary(bin1, bin2);
        sumBin = sumBin.PadLeft(bits, '0');

        Console.WriteLine($"\nСумма в двоичном виде: {sumBin}");

        int sumDec = BinaryToDecimal(sumBin, bits);

        Console.WriteLine($"Сумма в десятичном виде: {sumDec}");
    }
}