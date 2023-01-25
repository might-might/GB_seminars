// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



 
Console.Write("Вам нужно задать коэффициенты для первой прямой. Введите целое k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь нужно задать коэффициенты для второй прямой. Введите целое k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] WhatIsThePoint(int coefK1, int coefB1, int coefK2, int coefB2)
{
    double diff = coefB2 - coefB1;
    double diff_2 = coefK1 - coefK2;
    double x = diff / diff_2;
    double y = coefK1 * x + coefB1;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}


void PrintResult(double[] arr)
{
    if (k1 == k2) Console.Write("Прямые с указанными коэффициентами не пересекаются!");
    else Console.Write($"Координаты точки пересечения: ({arr[0]}; {arr[1]})");
}

WhatIsThePoint(k1, b1, k2, b2);
PrintResult(WhatIsThePoint(k1, b1, k2, b2));


// Еще сделал с одним методом войд. Не так элегантно, зато быстрее (наверное :) )

// Console.Write("Вам нужно задать коэффициенты для первой прямой. Введите целое k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Теперь нужно задать коэффициенты для второй прямой. Введите целое k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// void MainFunc(int coefK1, int coefB1, int coefK2, int coefB2)
// {
//     if (coefK1 == coefK2)
//     {
//         Console.Write("Прямые с заданными параметрами не пересекаются!");
//     }
//     else
//     {
//         double diff = coefB2 - coefB1;
//         double x = 0;
//         if (diff != 0)
//         {
//             double diff_2 = coefK1 - coefK2;
//             x = diff / diff_2;
//         }
//         double y = coefK1 * x + coefB1;
//         double[] array = new double[2];
//         array[0] = x;
//         array[1] = y;
//         Console.Write($"({array[0]}; {array[1]})");
//     }
// }

// MainFunc(k1, b1, k2, b2);