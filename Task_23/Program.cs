// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int index = 1; index < N; index ++)
{
    int num = index * index * index;
    Console.Write($"{num}, ");
}
Console.WriteLine(N * N * N);