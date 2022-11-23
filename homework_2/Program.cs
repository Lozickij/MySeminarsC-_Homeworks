/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. 
456 -> 5
782 -> 8
918 -> 1 */

/*void SecondNum(int tgnum)

{

int des = tgnum / 10;
Console.Write($"{tgnum} -> {des % 10}"); 

}

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

SecondNum(number);  */ 

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* void ThirdNum (int number)
{
   while (number >= 0)
   {
      if ((number >= 100) && (number < 1000)) 
      {
         Console.WriteLine($"{number} -> {number % 10}");
         break;   
      }
      if ((number < 100) && (number > 0))       
      {
         Console.WriteLine($"{number} -> третьей цифры нет");
         break;        
      } 
      number = number/ 10;
   }      
}

Console.Write("Введите любое целое число ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdNum(num); */

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

bool WeekNum (int numday)
{
    if (( numday == 6 ) || ( numday == 7))

    {
        return true;
    
    }
    else
    {
      return false;
    } 
}

Console.Write("Введите день недели от 1 до 7 ");
int day = Convert.ToInt32(Console.ReadLine());
bool D = WeekNum (day);

    if (D == false)
    {
      Console.WriteLine($"{day} -> нет"); 
    }
    if (D == true)
    {
      Console.WriteLine($"{day} -> да"); 
    }

//Console.WriteLine($"{day} -> {D}");             
    
   