//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число>");
int a = Convert.ToInt32(Console.ReadLine());
int s = 3;
int a1 = a /10 % 10;
Console.Write(a1);





Random rnd = new Random();
int x = rnd.Next(100 , 999);
int s = 2;
int m = 1;
while (s > 1) {
     m *= 10;
     s--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);