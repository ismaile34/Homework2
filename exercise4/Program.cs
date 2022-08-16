Console.WriteLine("Введите день недели>");
int A = Convert.ToInt32(Console.ReadLine());
if (A <= 5) 
{
    Console.WriteLine("Это будний день");
}
else if (A > 7) 
{
    Console.WriteLine("В неделе только 7 дней");
}
else
{
    Console.WriteLine("Это выходной день");
}