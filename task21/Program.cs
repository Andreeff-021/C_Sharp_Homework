// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату точки XA: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки YA: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки ZA: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки XB: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(
    Math.Pow((xb - xa), 2) + 
    Math.Pow((yb - ya), 2) + 
    Math.Pow((zb - za), 2));

Console.WriteLine(Math.Round(length, 2));