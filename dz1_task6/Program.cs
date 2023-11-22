Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine($"является ли {number} число четным? - да");
}
else
{
Console.WriteLine($"является ли число {number} четным? - нет");
}
