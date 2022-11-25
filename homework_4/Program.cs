// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int RaiseToDegree (int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i ++)
    {
        result = result * num1;
        //Console.WriteLine(result);
    }
    return result;
}

Console.Write("Input number A = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B = ");
int num2 = Convert.ToInt32(Console.ReadLine());
//int result = RaiseToDegree (num1, num2);
//Console.WriteLine($"{num1}, {num2} -> {result}");
Console.WriteLine($"{num1}, {num2} -> {RaiseToDegree (num1, num2)}"); 


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/* int SummDigit(int num)
{
    int summ = 0;
    while(num > 0)
    {
        summ = summ + num % 10;
        //Console.WriteLine(summ);
        num = num / 10;
    }
    return summ;
} 

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} -> {SummDigit(number)}"); */

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/* void CreateArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 101);
        if (i == size - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
CreateArray(a);
Console.Write(" -> ");
Console.Write("[ ");
CreateArray(a);
Console.Write(" ]"); */
