// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координату x точки A: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
double Za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
double Zb = Convert.ToDouble(Console.ReadLine());
double AB = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));
Console.WriteLine($"Расстояние равно {AB}");