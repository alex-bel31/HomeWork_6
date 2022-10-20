// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = GetAndPrintValue("Введите значение b1");
double k1 = GetAndPrintValue("Введите число k1"); 
double b2 = GetAndPrintValue("Введите значение b2");
double k2 = GetAndPrintValue("Введите число k2");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2; 
Console.WriteLine($"b1 = {b1}, k1 {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");

double GetAndPrintValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    double value = Convert.ToDouble(input);
    return value;
}
