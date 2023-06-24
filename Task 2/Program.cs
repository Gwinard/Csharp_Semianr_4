// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int NumLenght(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}

int Sum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int lenght = NumLenght(number);
Console.WriteLine($"Суума цифр в введенном числе: {Sum(number, lenght)}");

