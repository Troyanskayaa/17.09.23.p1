// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1 * n;
if (count % 2 == 0)
{
    Console.Write($"{count} ");
}
else if (count % 2 != 0)
{
    Console.Write("");
}


// while(count <= n)
// {
//     Console.Write($"{count} ");
//     count = count + 1;
// }
