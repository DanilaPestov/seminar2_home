Console.Write("введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());
if (day >= 1 & day <= 5)
{
    Console.WriteLine("рабочий день :)");
}
if (day >= 6 & day <= 7)
{
    Console.WriteLine("(: ВЫХОДНОЙ :)");
}
else Console.WriteLine("таких дней в неделе не существует");