// Массивы и функции в программировании

Console.WriteLine("Задача № 15");
Console.WriteLine("--------------------------------");

string [] day = {"Понедельник", "Вторник", "Среда","Четверг","Пятница","Суббота","Воскресенье"};

Console.Write("Вводите целое число (1-7) : ");
int number = Convert.ToInt32(Console.ReadLine( ));

if (number >= 1 && number <= 7)
{
    Console.Write(" Это " + day[number - 1]);
if ( number==6 || number==7)
{
    Console.Write(" - Выходной день.");
}
}
else
{
    Console.WriteLine("Этого дня не существует!!!");
}