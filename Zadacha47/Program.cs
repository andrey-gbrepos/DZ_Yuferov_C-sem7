//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

double[,] doublArr = GetArray(rows, columns);
PrintArray(doublArr);

double [,] GetArray (int m, int n)
{
    long sign = 1;
    double[,] res = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            sign = (new Random().Next(0, 10))%2 == 0 ? 1 : -1;//генератор случайного +/-

        //Получаем случайное вещественное число (0 - 10),  и округляем до второго знака
            res [i,j] = Math.Round((new Random().NextDouble())*10, 1) * sign; 
        }
    }
    return res;
}


void PrintArray (double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
