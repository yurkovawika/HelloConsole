 ///Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число a > ");
long number_a = long.Parse(Console.ReadLine());
Console.Write("Введите число b > ");
long number_b = long.Parse(Console.ReadLine());

if (number_a > number_b)
{
    Console.WriteLine($"Число {number_a} больше, чем число {number_b}");
}
else
{
    Console.WriteLine($"Число {number_b} больше, чем число {number_a}");
}