// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех цифр числа равна = {Summa(num)}");

int Summa(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum += N % 10;
        N /= 10;
    }
    return sum;
}
