// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    Console.WriteLine("Введите элементы массива (через пробел):");
    string input = Console.ReadLine();
    
    string[] numbers = input.Split(' ');
    int[] array = Array.ConvertAll(numbers, int.Parse);
    
    PrintArrayReversed(array, array.Length - 1);
}

void PrintArrayReversed(int[] array, int index)
{
    if (index < 0) 
        return;

    Console.Write(array[index] + " "); 

    PrintArrayReversed(array, index - 1); 
}
Main();