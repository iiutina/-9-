/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
 
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNumbers (int number)
{
Console.Write (number + " "); 
if (number>1) ShowNumbers (number-1);

}
ShowNumbers (5);
*/

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
 

 int ShowSumma (int m, int n)

{
    if (  n>=m && n>0 && m>0 )  return n+ ShowSumma (m,n-1); 
    else  return 0; 
    
}

  int sum=ShowSumma(4,8);
  
Console.Write ($"{sum}");
 
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/
/*
int Ack (int m,int n)
{
    if (m==0)
    {
    return n+1;
    }
    else
    {
         if (n == 0 && m > 0)
         {
           return Ack (m - 1, 1); 
         }
         else
         {
            return Ack(m - 1, Ack(m, n - 1));
         }
    } 
    
}
int ack=Ack(2,3);
Console.Write ($" {ack}");
*/