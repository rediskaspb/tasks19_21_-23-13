// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты X точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {length:f2}");
