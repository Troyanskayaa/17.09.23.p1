﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; // 0 1 2 3 4 5 6 7

array[0] = 3453;
array[4] = 545;
array[7] = 64;

for (int i = 0; i < array.Length; i++)
{
    array[i] = i * i;
    Console.Write(array[i] + " ");
}


