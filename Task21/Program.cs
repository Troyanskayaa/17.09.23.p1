// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координаты точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, x2, y1, y2, z1, z2); 
Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");

double Distance(int xValue1, int xValue2, int yValue1, int yValue2, int zValue1, int zValue2)
{
    double result = Math.Sqrt(Math.Pow((xValue2 - xValue1), 2) + Math.Pow((yValue2 - yValue1), 2) + Math.Pow((zValue2 - zValue1), 2));
    return result;
}