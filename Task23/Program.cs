// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCub(num);

void TableCub(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 3} -> {(count * count) * count, 6}");
        count += 1;
    }
}