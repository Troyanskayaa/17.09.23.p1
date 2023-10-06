// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;
int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
    return sum;
}
int sumNumbers = SumNumbers(number);
Console.WriteLine($"{number} -> {sumNumbers}");