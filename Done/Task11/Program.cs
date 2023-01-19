int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;
Console.WriteLine(firstDigit);
Console.WriteLine(thirdDigit);
Console.WriteLine($"{firstDigit}{thirdDigit}");