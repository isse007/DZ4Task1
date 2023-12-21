// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int ReadInt(string msg)
{
     System.Console.WriteLine(msg);    
     return Convert.ToInt32(Console.ReadLine());
} 

int n = ReadInt("Введите число");


int sum;
while (n>10)
{
    sum = sum + n%10;
    n = n/10;
}
string q;
if n == q && sum%2 = 0 break;
else ReadInt();