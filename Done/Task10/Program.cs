Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
void GetNumberWithoutSecondDigit(int num)
{
    int firstDigit = numberA / 100;
    int thirdDigit = numberA % 10;
    Console.WriteLine(firstDigit * 10 + thirdDigit);
}

GetNumberWithoutSecondDigit(numberA);