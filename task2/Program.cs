// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третье число");
int c = int.Parse(Console.ReadLine()!);

int max = 0;


if (max < a)
    max = a;
if (max < b)
    max = b;
if (max < c)
    max = c; 
    
Console.Write("максимальное число: ");
Console.WriteLine(max);
