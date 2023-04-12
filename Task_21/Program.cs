// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координату x точки A не равную нулю: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A не равную нулю: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки A не равную нулю: ");
double Za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x точки B не равную нулю: ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B не равную нулю: ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B не равную нулю: ");
double Zb = Convert.ToDouble(Console.ReadLine());
double AB = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));
Console.WriteLine($"Расстояние равно {AB}");