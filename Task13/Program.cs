﻿// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int umbern = Convert.ToInt32(Console.ReadLine());

int thirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool result(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
        return false;
    }
    return true;
}
if (result(number))
{
    Console.WriteLine(thirdDigit(number));
}

