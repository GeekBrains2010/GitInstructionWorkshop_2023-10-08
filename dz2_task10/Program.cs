Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) < 100 || Math.Abs(number) > 999)
{
Console.WriteLine("Число не является трёхзначным.");
return;
}

int secondDigit = (Math.Abs(number) / 10) % 10;
Console.WriteLine($"Вторая цифра числа: {secondDigit}");
