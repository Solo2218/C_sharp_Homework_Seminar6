// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты 1-й прямой: ");
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты 2-й прямой: ");
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
double[] intersectionPoint = new double[2];
intersectionPoint[0] = CalculationXPositionOfIntersectionPoint(b1, k1, b2, k2);
intersectionPoint[1] = CalculationYPositionOfIntersectionPoint(b1, k1, intersectionPoint[0]);
PrintIntersectionPoint(intersectionPoint);


double CalculationXPositionOfIntersectionPoint(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double CalculationYPositionOfIntersectionPoint(double b1, double k1, double x)
{
    return (k1 * x + b1);
}

void PrintIntersectionPoint(double[] array)
{
    Console.WriteLine($"Точка пересечения: ({array[0]:f1}, {array[1]:f1})");
}
