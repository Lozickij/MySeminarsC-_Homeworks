/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

/* double[,] Create2DRandomArray(int rows,  int columns)
{
    double[,] newArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = Math.Round((new Random().NextDouble()*(11.9+10.9)-10.9), 1);
        }
    }
    return newArray;
}

void Show2DArray(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"m = {m}, n = {n}.");  // В данном контексте, по-моему, лишнее ..
Show2DArray(Create2DRandomArray(m, n));  */

/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

/* int[,] Create2DArray (int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(1, 11);
        }
    }
    return newArray;
}

void FindElementByIndex(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (a < array.GetLength(0) && b < array.GetLength(1)) 
        Console.Write($"Значение элемента [{a}, {b}] -> {array[a, b]}.");
    else Console.Write($"[{a}, {b}] -> Такого элемента нет!");
}

Console.Write("Введите количество строк - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс числа i = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс числа j = ");
int b = Convert.ToInt32(Console.ReadLine());

FindElementByIndex(Create2DArray(rows,columns), a, b); */


/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

// На неквадратных массивах работает криво!? Но я уже голову сломал. 

int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
} 

void Show2DArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
    
        Console.WriteLine(); 
    } 
    Console.Write("Среднее арифметическое каждого из столбцов равно: "); 
    for (short i = 0; i < array.GetLength(0); i++)
     {
        double row = array.GetLength(0);
        int sum = 0;
        for (short j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        
        Console.Write(Math.Round(sum/row, 1) + "; ");
     }  
}

Show2DArray(Create2DRandomArray(1, 9, 5, 5));