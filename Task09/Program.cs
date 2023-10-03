// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99 + 1);
Console.WriteLine($"случайное число из отрезка [10, 99] -> {number}");
// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) 
// {
//     Console.WriteLine($"Найбольшую цифру числа -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Найбольшую цифру числа -> {secondDigit}");
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Найбольшую цифру числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Найбольшую цифру числа -> {maxDigit}");

int MaxDigit (int num)
{
   int firstDigit = num / 10; // 78 / 10 = 7
   int secondDigit = num % 10;
   return maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit1 = MaxDigit(23);
Console.WriteLine($"Найбольшую цифру числа -> {maxDigit1}");
