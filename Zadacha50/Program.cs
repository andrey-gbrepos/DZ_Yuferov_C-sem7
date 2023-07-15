//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();
WriteLine("Программа определит, есть ли элемент с запрашиваемой позицией  в массиве");
WriteLine("(Двумерный массив генерируется случайным образом.");
WriteLine(" Минимальный размер возможного массива 2х2; Максимальный 20х20)");

int[,] Arr = NewArr(); //Генерация случайного двумерного массива
                                            WriteLine();
PrintArray(Arr);
                                            WriteLine();
Console.WriteLine("Введите c клавиатуры номер строки и через пробел номер столбца затем 'ENTER'");
string strinpos = Console.ReadLine();
                                            WriteLine();
int[] posar = posArr(strinpos);//Одномерный массив с позицией элемента

if (InOrOut(Arr, posar)) 
{Console.WriteLine($"Значение искомого Элемента: {Arr[posar[0],posar[1]]}");}
else {Console.WriteLine($"Такого элемента нет");}



bool InOrOut (int[,] MainAr, int[] position) // Проверка позиции: входит в массив или не входит
{
    bool i = true;
if (position[0] > MainAr.GetLength(0) -1 || position[1] > MainAr.GetLength(1) -1) 
    return i = false;
else return i = true;
}


int[] posArr (string elem)// Перевод строки в массив int[]
{
    string[] num = elem.Split(" ");
    int[] pz = new int[num.Length];
    for (int i =0; i < pz.Length; i++)
    {
        pz[i] = Convert.ToInt32(num[i]);
    }
    return pz;
}


int [,] NewArr () //генератор двумерного массива
{
    int row = 2;
    int col = 2;
    row = new Random().Next(2, 20);
               
    col = new Random().Next(2, 20);
              
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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
