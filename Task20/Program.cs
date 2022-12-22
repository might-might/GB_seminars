// Напишите программу, которая приимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве.
// А(3,6); В(2,1) -> 5,09

Console.WriteLine("Введите первую координату точки A():");
int pointA1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки A():");
int pointA2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("Введите первую координату точки B():");
int pointB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки B():");
int pointB2 = Convert.ToInt32(Console.ReadLine());

// Math.Pow();
// Math.Sqrt();
// Math.Round(d, 2, MidpointRounding.ToZero);

double Dist(int num1, int num2, int num3, int num4)
{
    double hypotenuse = Math.Sqrt((num1 - num3) * (num1 - num3)
        + (num2 - num4) * (num2 - num4));
    hypotenuse = Math.Round(hypotenuse, 2, MidpointRounding.ToZero);
    return hypotenuse;
}
Console.WriteLine($"Расстояние между двумя точками равно {Dist(pointA1, pointA2, pointB1, pointB2)}");