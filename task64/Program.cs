//  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//  M = 1; N = 5 -> "2, 4"
//  M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string msg)
{
    Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEvenNumber(int m, int n)
{
   if(m > n)
   {
      return;
   }
   if(m % 2 == 0)
   {
      Console.Write($"{m}\t ");
   PrintEvenNumber(m + 2, n);
   }
   else 
   {
      PrintEvenNumber(m + 1, n);
   }
}

int m=ReadInt("Введите первое число: ");
int n=ReadInt("Введите второе число: ");

PrintEvenNumber(m, n);




