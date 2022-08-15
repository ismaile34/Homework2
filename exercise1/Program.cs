// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string message);
{
    System.Console.Write(message);
    
}
Console.WriteLine("Введите трехзначное число>");
int A = Convert.ToInt32(Console.ReadLine());
int A1 = A /10 % 10;
Console.Write(A1);