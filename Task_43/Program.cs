// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, 
//                      y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
double x = 0;
double y = 0;
Console.Write("Введите значение b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
x = (b2 - b1) / (k1 - k2);
y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
Console.WriteLine($"{x}, {y}");