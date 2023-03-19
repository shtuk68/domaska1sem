// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine()!);
int max = 0;
int min = 0;

if (a > b)
    {max = a;
    min = b;}
 else
 {  max = b;
    min = a;} 
Console.Write("минимальное число: ");    
Console.WriteLine(min);
Console.Write("максимальное число: ");
Console.WriteLine(max);
