// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MultipleTwoNumbers (int num1, int num2, int num3)
{
   return num1 % num2 == 0 && num1 % num3 == 0;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int firstNumber = 7;
int secondNumber = 23;
// if (num % firstNumber == 0 && num % secondNumber == 0)
// {
//     Console.WriteLine($"{num} -> Да");
// }
// else
// {
//     Console.WriteLine($"{num} -> Нет"); 
// }
bool result = MultipleTwoNumbers(num, firstNumber, secondNumber);
Console.WriteLine(result ? $"{num} -> Да" : $"{num} -> нет");