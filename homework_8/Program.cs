/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] Create2DArray(int rows, int columns)  
{
    int[,] newArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(1, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortForMin(int[,] array)    
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }

    return array;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DArray(m, n);
Show2DArray(myArray); 
Console.WriteLine();
Show2DArray(SortForMin(myArray)); 

/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

/*int[,] Create2DArray(int rows, int columns)  
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
}

int[,] FindMinSum(int[,] array)         
{ 
int[] arrayRes = new int[array.GetLength(0)];  
    int summ1 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ1 += array[i, j];   
        }
        //Console.WriteLine(summ1);
        arrayRes[i] = summ1; 
        summ1 = 0; 
    }

    int min = 0;    
    for (int j = 1; j < array.GetLength(1); j++)
    {
        if (arrayRes[j] < arrayRes[min])  
            min = j;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min +1}-я строка.");
    Console.WriteLine();
    return array;
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DArray(m, n);
Show2DArray(myArray); 
Console.WriteLine();
FindMinSum(myArray); */

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*int[,] CreateMatrix1 (int row, int col, int min, int max) 
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
} 
 
int[,] CreateMatrix2 (int row, int col, int min, int max) 
{
    int[,] matrix2 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix2;
} 
 
void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1} ");
            else Console.Write($"{matrix[i, j], 1} ");
        }
        Console.Write("|");        
    }       
}
 
void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1} ");
            else Console.Write($"{matrix[i, j], 1} ");
        }
        Console.Write("|");        
    }        
}
 
int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if(matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        Console.WriteLine("Умножение матрицы невозможно!");
    }
    else 
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

void PrintMatrix3(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1} ");
            else Console.Write($"{matrix[i, j], 1} ");
        }
        Console.WriteLine(" ");        
    }        
}
 
int[,] matrix1 = CreateMatrix1(2, 2, 0, 9);
int[,] matrix2 = CreateMatrix2(2, 2, 0, 9);
int[,] matrix3 = DivMatrix(matrix1, matrix2);
PrintMatrix1(matrix1);
Console.WriteLine();
PrintMatrix2(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");
PrintMatrix3(matrix3);  */

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*int[,,] array3D = new int[2, 2, 2];

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

FillArray(array3D);
PrintIndex(array3D); */

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*void FillArraySpiral(int[,] array, int n)    // Проковырялся почти сутки
{                                            // В итоге с GitHubа стащил ..
    int i = 0;                               // Мне такое точно самому за неделю не написать!
    int j = 0;                               // Все как то попроще представлялось, 
    int value = 1;                           // Такие штуки без справочника даже не расшифровать мне!
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do 
        { 
            array[i, j++] = value++; 
        } 
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table); */
