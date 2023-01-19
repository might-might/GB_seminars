int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

int result = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.Write("Наибольшая цифра числа - ");
Console.WriteLine(result);