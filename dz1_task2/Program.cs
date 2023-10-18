Console.WriteLine("Введите первое число (a):");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число (b):");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max = {a} min = {b}");
}
else  if (a < b)
{
    Console.WriteLine($"max = {b}  min = {a}");
}
else
{
    Console.WriteLine($"{a} = {b}");
}