Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99)
{
    Console.WriteLine("третьей цифры нет");
}
if (number > 99 & number <= 999)
{
    if (number % 10 == 0)
    {
        Console.WriteLine("третья цифра: 0");
    }
    else
    {
        Console.WriteLine("третья цифра: " + number % 10);
    }
}
if (number > 999 & number <= 9999)
{
    if (number % 100 / 10 == 0)
    {
        Console.WriteLine("третья цифра: 0");
    }
    else
    {
        Console.WriteLine("третья цифра: " + number % 100 / 10);
    }
}
if (number > 9999 & number <= 99999)
{
    if (number % 1000 / 100 == 0)
    {
        Console.WriteLine("третья цифра: 0");
    }
    else
    {
        Console.WriteLine("третья цифра: " + number % 1000 / 100);
    }
}