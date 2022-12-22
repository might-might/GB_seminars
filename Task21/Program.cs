// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите первую координату точки A():");
int pointA1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки A():");
int pointA2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату точки A():");
int pointA3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату точки B():");
int pointB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки B():");
int pointB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату точки B():");
int pointB3 = Convert.ToInt32(Console.ReadLine());

// Math.Pow(counter, 2);
// Math.Sqrt();
// Math.Round(d, 2, MidpointRounding.ToZero);

double Dist(int num1, int num2, int num3, int num4, int num5, int num6)
{
    double hypotenuse = Math.Sqrt((num1 - num4) * (num1 - num4)
        + (num2 - num5) * (num2 - num5)+ (num3 - num6) * (num3 - num6));
    hypotenuse = Math.Round(hypotenuse, 2, MidpointRounding.ToZero);
    return hypotenuse;
}
Console.WriteLine($"Расстояние между двумя точками равно {Dist(pointA1, pointA2, pointA3, pointB1, pointB2, pointB3)}");