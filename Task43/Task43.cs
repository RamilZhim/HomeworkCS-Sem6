// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения для: ");

double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = ReadInt("b1 = ");
double k1 = ReadInt("k1 = ");
double b2 = ReadInt("b2 = ");
double k2 = ReadInt("k2 = ");
double x = GetX(b1, b2, k1, k2);
double y = GetY(b1, b2, k1, k2, x);

double GetX(double b1, double b2, double k1, double k2)
{
    x = 0;
    x = (b2 - b1) / (k1 - k2);
    return x;
}

double GetY(double b1, double b2, double k1, double k2, double x)
{
    y = 0;
    y = k1 * x + b1;
    return y;
}

void PrintCrossing(double GetX, double GetY)
{
    Console.Write($"Точка пересечения двух прямых: ({GetX}; {GetY})");
}

PrintCrossing(x, y);

