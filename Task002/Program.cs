// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите число (b1). b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число (b2). b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число (k1). k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число (k2). k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());



void FindPoint(double b1, double b2, double k2, double k1)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"{x}      {y}");
}

FindPoint(b1, b2, k2, k1);