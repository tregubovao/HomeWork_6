// Показать числа Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

void GenerateArrayElement(int[] array, int lenght)
{
    array[0] = 1;
    array[1] = 1;
    for (int i = 2; i < lenght; i++) 
    array[i] = array[i - 1] + array[i - 2];
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}

Console.Write("Введите количество элементов числовой последовательности (чисел Фибоначчи): ");
int lenght = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[lenght];
GenerateArrayElement(array, lenght);
Console.WriteLine("Числа Фибоначчи: ");
PrintArray(array);
