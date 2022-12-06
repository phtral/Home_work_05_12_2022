//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты X первой точки");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y первой точки");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Z первой точки");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты X второй точки");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y второй точки");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Z второй точки");
double z2 = double.Parse(Console.ReadLine()!);

double ab = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

Console.WriteLine($"Расстояние между точками {ab}");