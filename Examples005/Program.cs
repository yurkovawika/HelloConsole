// Напишите программу, которая принимает на вход число и выдаёт его квадрат.
Console.Write("Введите число >");              //Вывод в консоль приглашения
string inputStr = Console.ReadLine();              // Ввод строки с консоли
int number = int.Parse(inputStr);              //Преобразование введенной строки в целое число
int result = number * number;              //Вычисление квадрата
Console.WriteLine($"Квадрат числа {number} равен {result}");              //Вывод результата на экран
