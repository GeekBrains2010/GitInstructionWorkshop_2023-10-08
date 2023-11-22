Console.WriteLine("Введите цифру, обозначающую день недели (1-7):");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
Console.WriteLine("да");
}
else if (day >= 1 && day <= 5)
{
Console.WriteLine("нет");
}
else
{
Console.WriteLine("Введена неверная цифра. Пожалуйста, введите число от 1 до 7.");
}
