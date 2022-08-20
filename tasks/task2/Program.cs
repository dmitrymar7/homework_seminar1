Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
    max = b;
}
Console.WriteLine("max = " + max);
