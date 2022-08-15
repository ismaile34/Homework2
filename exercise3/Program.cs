//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Random rnd = new Random();
int x = rnd.Next(100 , 999);
Console.WriteLine(x);
int s = 2;
int m = 1;
while (s > 1) {
     m *= 10;
     s--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);
