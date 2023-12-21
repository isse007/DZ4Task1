// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int ReadInt(string msg)
{
     System.Console.WriteLine(msg);    
     return Convert.ToInt32(Console.ReadLine());
} 

int[] Generate(int size, int leftRange, int rightRange)
{
     int[] array = new int[];
     for (int i = 0; i < array.Lenght; i++)
     {
        array[i] = new Random().Next(leftRange, rightRange+1);
        Random rand = new Random();
    }
     return array;
} 

void PrintArray (int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.WriteLine(arrayForPrint[i]+" ");
    }
}
int Osnovnoe (int[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if inputArray[i]%2=0;
        count++;
        retirn count;
    }
}

int n = ReadInt("Введите число");
int[] myArray = GenerateArray (n,100,999);
PrintArray(myArray);
System.Console.WriteLine(Osnovnoe(myArray));