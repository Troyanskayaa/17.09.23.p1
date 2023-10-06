// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Result = Math.Pow(numberA, numberB);
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
bool ValidateExponent(int numberB)
{
    if (numberB < 0)
    {
        Console.WriteLine("Число не должно быть меньше 0");
        return false;
    }
    return true;
}
Console.WriteLine($"{numberA} , {numberB} -> {Math.Pow}");