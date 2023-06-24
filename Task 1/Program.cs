// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

double Pow(int num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}

Console.WriteLine($"Результат возведения чичла А в натруальную степень В: {Pow(numberA, numberB)}");

