// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine()!);

void RandomeArray(int[] random)
{
    for (int i = 0; i < random.Length; i++)
    {
        random[i] = new Random().Next(-2147483648, 2147483647);
    }
}

void LengthArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]} ");
    }
}

int[] array = new int[n];
RandomeArray(array);
LengthArray(array);
