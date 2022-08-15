//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Random rnd = new Random();
int a = rnd.Next(100 , 1000);
Console.WriteLine(a);
int b = 10 * ( a / 100 ) + ( a % 10 );
Console.Write(b);