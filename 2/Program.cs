﻿/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 1 - > 1*/

int [,] CreateArray(int m=3, int n =4)
{
    int [,] array = new int [m,n];
    Random rnd = new Random ();
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
        {
            array[ i,j]= rnd.Next(1,10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for(int j=0; j< array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+"\t");
        }
    }
    System.Console.WriteLine();
}

int InputInt(string msg)
{
    System.Console.Write(msg +">");
    return Convert.ToInt32(Console.ReadLine());
}
int[,]resultArray = CreateArray();
PrintArray(resultArray);
int n= InputInt ("Введите номер строка");
int m = InputInt("Введите номер столбца");
if(n>resultArray.GetLength(0)|| m> resultArray.GetLength(1))
{
    System.Console.WriteLine("Такого элемента нет в заданном массиве!");
}
else
{
    System.Console.WriteLine($"значение элемента {m}столбца и {n}строки равно {resultArray[n-1,m-1]}");
}

