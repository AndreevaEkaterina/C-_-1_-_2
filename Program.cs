// Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
Console.Clear();
Console.Write("ВВедите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите второе число:");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"Число {a} - большее, а число {b} - меньшее.");
}
else
{
    Console.WriteLine($"Число {b} - большее, а число {a} - меньшее.");
}