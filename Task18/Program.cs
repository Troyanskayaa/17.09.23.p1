﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

string QuarterToCoords(int quadr)
{
    if(quadr == 1) return "x > 0, y > 0";
    if(quadr == 2) return "x < 0, y > 0";
    if(quadr == 3) return "x < 0, y < 0";
    if(quadr == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");

Console.Write("quater: ");
int quater = Convert.ToInt32(Console.ReadLine());

string result = QuarterToCoords(quater);

Console.WriteLine(result != null ? result : "Не является номероом четверти" );

