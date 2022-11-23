/* Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да  */

void IfPal (int num)
{
    int first = num / 10000;
   // Console. WriteLine(first);
    int fifth = num % 10;
    //Console. WriteLine(fifth);
    int second = num / 1000 - first * 10;
    //Console. WriteLine(second);
    int fourth = (num % 100 - fifth) / 10;
    //Console. WriteLine(fourth);

    if ((first == fifth) && (second == fourth))
    {
        Console. WriteLine($"{num} -> является");
    }
     if ((first != fifth) || (second != fourth))
    {
        Console. WriteLine($"{num} -> не является");
    }    
} 

Console.Write ("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());

IfPal (num); 

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* double GetLens(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 -y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

    return len;
}

Console.Write("Input coordinate X1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate X2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate Z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(GetLens(1, 5, -8, 2, 6, -7));                     //Math.Round(3.125, 2); - Округление

//Console.WriteLine(Math.Round(GetLens(x1, y1, z1, x2, y2, z2), 2));

Console.WriteLine($"A {( x1, y1, z1)}; B {( x2, y2, z2)} -> {Math.Round(GetLens(x1, y1, z1, x2, y2, z2), 2)}"); */   //  A (3,6,8); B (2,1,-7), -> 15.84

/* Задача 23
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*void Sqrol(int N)
{
    for(int i = 1; i <= N; i++)
    {
        Console.Write($"{i * i * i}, ");   
    }
}

Console.Write ("Введите число N = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write($"{x} -> ");

Sqrol(x); */