Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) < 100)
{
Console.WriteLine("Третьей цифры нет.");
return;
}

int thirdDigit = (Math.Abs(number) / 100) % 10;
Console.WriteLine($"Третья цифра числа: {thirdDigit}");
