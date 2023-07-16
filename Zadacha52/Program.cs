//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();
WriteLine("Программа подсчитывает среднее арифметическое чисел в каждом столбце двумерного массива");
WriteLine("(Двумерный массив генерируется случайным образом.");
WriteLine(" Минимальный размер возможного массива 2х2; Максимальный 10х10)");

int[,] Arr = NewArr(); //Генерация случайного двумерного массива
                                            WriteLine();
PrintArray(Arr);
                                           
WriteLine("-------------------");

WriteLine(String.Join("   ",Aver(Arr)));

WriteLine("-------------------");

double[] Aver(int[,] randAr)//Подсчет среднего арифметического по столбцам
{
double[] Ar = new double[randAr.GetLength(1)];

for (int i = 0; i < randAr.GetLength(1); i++ )//Перебор столбцов
    {
        for(int j = 0; j < randAr.GetLength(0); j++)//Перебор строк
        {
            Ar[i] =  Ar[i] + randAr[j, i];
        }
       Ar[i] = Math.Round(Ar[i]/(randAr.GetLength(0)), 1);
    }
    return Ar;
}


int [,] NewArr () //генератор двумерного массива
{
  
   
    int row = new Random().Next(2, 11);
               
    int col = new Random().Next(2, 11);
              
    int[,] res = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            res [i,j] = new Random().Next(0,10); 
        }
    }
    return res;
}


void PrintArray (int[,] inArray) //Вывод двумерного массива
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}    ");
        }
        WriteLine();
    }
}

