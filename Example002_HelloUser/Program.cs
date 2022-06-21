//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Write("Введите число от 1 до 7 >");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.WriteLine($"{number} это понедельник");
if (number == 2) Console.WriteLine($"{number} это вторник");
if (number == 3) Console.WriteLine($"{number} это среда");
if (number == 4) Console.WriteLine($"{number} это четверг");
if (number == 5) Console.WriteLine($"{number} это пятница");
if (number == 6) Console.WriteLine($"{number} это суббота");
if (number == 7) Console.WriteLine($"{number} это воскресенье");
if (number > 8)
{
    Console.WriteLine($"{number} такого дня недели нет");
}