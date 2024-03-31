// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример m = 2, n = 3 -> A(m,n) = 9



void Main()
{
    
    Console.Write("Введите значение m: ");
    string? inputM = Console.ReadLine();
    int m;

    
    if (!int.TryParse(inputM, out m))
    {
        Console.WriteLine("Ошибка ввода для m.");
        return;
    }

    Console.Write("Введите значение n: ");
    string? inputN = Console.ReadLine();
    int n;

    
    if (!int.TryParse(inputN, out n))
    {
        Console.WriteLine("Ошибка ввода для n.");
        return;
    }

    
    int result = AckermannFunction(m, n);
    Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;

    
    if (n == 0)
        return AckermannFunction(m - 1, 1);

    
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Main();
