// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точек");
Console.Write("X:");
int xCoorinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int yCoorinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoorinate, yCoorinate);

string result = quarter > 0 ? $"Уквзвнные координаты соответствуют четвери {quarter}" 
                            : "Введена некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}