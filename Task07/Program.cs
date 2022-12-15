Console.WriteLine("Введите трезначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA >= 100 && numberA <= 999)
{
    int result = numberA % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели нетрехзначное число");
}
