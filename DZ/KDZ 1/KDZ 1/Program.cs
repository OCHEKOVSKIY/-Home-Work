using System;

class BullsAndCows
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру 'Быки и Коровы'!");
        Console.WriteLine("Выберите режим игры:");
        Console.WriteLine("1. Игрок против Игрока");
        Console.WriteLine("2. Игрок против Компьютера");
        Console.Write("Введите номер режима (1 или 2): ");
        string mode = Console.ReadLine();

        if (mode == "1")
            PlayerVsPlayer();
        else if (mode == "2")
            PlayerVsComputer();
        else
            Console.WriteLine("Некорректный выбор. Перезапустите игру и выберите 1 или 2.");
    }

    static void PlayerVsPlayer()
    {
        Console.Write("Игрок 1, введите секретное число (4 разные цифры): ");
        string secretNumber = Console.ReadLine();
        while (!IsValidInput(secretNumber))
        {
            Console.Write("Некорректное число. Введите 4 разные цифры: ");
            secretNumber = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Игрок 2, попробуйте угадать число!");

        PlayGame(secretNumber);
    }

    static void PlayerVsComputer()
    {
        string secretNumber = GenerateSecretNumber();
        Console.WriteLine("Компьютер загадал число. Попробуйте его угадать!");

        PlayGame(secretNumber);
    }

    static void PlayGame(string secretNumber)
    {
        int attempts = 0;
        bool isGuessed = false;

        while (!isGuessed)
        {
            attempts++;
            Console.Write("Ваш вариант: ");
            string guess = Console.ReadLine();

            if (!IsValidInput(guess))
            {
                Console.WriteLine("Некорректный ввод. Введите 4 разные цифры.");
                continue;
            }

            int bulls = CountBulls(secretNumber, guess);
            int cows = CountCows(secretNumber, guess);

            Console.WriteLine($"{bulls} быка(ов), {cows} корова(ы).");

            if (bulls == 4)
            {
                isGuessed = true;
                Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
            }
        }
    }

    static string GenerateSecretNumber()
    {
        Random random = new Random();
        string number;
        do
        {
            number = random.Next(1000, 10000).ToString();
        } while (!HasUniqueDigits(number));
        return number;
    }

    static bool HasUniqueDigits(string number)
    {
        for (int i = 0; i < number.Length; i++)
            for (int j = i + 1; j < number.Length; j++)
                if (number[i] == number[j])
                    return false;
        return true;
    }

    static bool IsValidInput(string input)
    {
        return input.Length == 4 && int.TryParse(input, out _) && HasUniqueDigits(input);
    }

    static int CountBulls(string secret, string guess)
    {
        int bulls = 0;
        for (int i = 0; i < secret.Length; i++)
            if (secret[i] == guess[i])
                bulls++;
        return bulls;
    }

    static int CountCows(string secret, string guess)
    {
        int cows = 0;
        for (int i = 0; i < guess.Length; i++)
            if (secret.Contains(guess[i]) && secret[i] != guess[i])
                cows++;
        return cows;
    }
}