// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер от 1-7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1)
{
    Console.WriteLine($"{dayNumber} -> Понедельник");
}
else if (dayNumber == 2)
{
    Console.WriteLine($"{dayNumber} -> Вторник");
}
else if (dayNumber == 3)
{
    Console.WriteLine($"{dayNumber} -> Среда");
}
else if (dayNumber == 4)
{
    Console.WriteLine($"{dayNumber} -> Четверг");
}
else if (dayNumber == 5)
{
    Console.WriteLine($"{dayNumber} -> Пятница");
}
else if (dayNumber == 6)
{
    Console.WriteLine($"{dayNumber} -> Суббота");
}
else if (dayNumber == 7)
{
    Console.WriteLine($"{dayNumber} -> Воскресенье");
}
else 
{
    Console.WriteLine("Номер является недействительным.");
}