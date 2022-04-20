int number = new Random().Next(100, 1000);
Console.WriteLine("наше число: " + number);
int number1 = number / 100;
int number2 = number % 10;
Console.WriteLine($"удалили вторую цифру: {number1}{number2}");