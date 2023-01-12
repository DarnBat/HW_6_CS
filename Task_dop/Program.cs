Console.Clear();
Console.Write("Введите координату x1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x3 : ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y3 : ");
int y3 = Convert.ToInt32(Console.ReadLine());

double result = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2-y1));
Console.WriteLine(result);