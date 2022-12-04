/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/*void ShowNumbers(int n)
{
    if(n >= 1)
    {
        Console.Write(n + ",");
        ShowNumbers(n - 1);
    }
}
Console.Write("Введите целое число N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {15} -> ");
Console.Write('"');
ShowNumbers(n);
Console.Write('"'); */

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке 
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/*int NaturalNumbersSum (int m, int n)
{
    int sum = m;

    if(n > m)
    {
        m++;
        sum = sum + NaturalNumbersSum(m, n);
    }
    return sum;
}
Console.Write("Введите целое число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {M}; N = {N} -> {NaturalNumbersSum(M, N)}"); */

/*Задача 68: Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int Akkerman(int m, int n)    // Интересно, это открытие практическое применение имеет ..?
{
    if (m == 0)
    {
        return n + 1;         // Если m = 0, A(m, n) = n + 1
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);    // m > 0 a n = 0, A(m-1, 1)
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));  // m > 0 и n > 0, A(m-1, A(m, n-1))
    }
}
Console.Write("Введите положительное целое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {m}, n = {n} -> {Akkerman(m, n)}");   
