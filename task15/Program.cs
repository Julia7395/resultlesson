// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 
Console.WriteLine("Введите цифру, обозначающую день недели");
int number1 = Convert.ToInt32(Console.ReadLine()); 

if (number1 == 1) 
{
    Console.WriteLine("День не является выходным");
}
if (number1 == 2)
{
    Console.WriteLine("День не является выходным");
}
if (number1 == 3)
{
   Console.WriteLine("День не является выходным ");
}
if (number1 == 4)
{
    Console.WriteLine("День не является выходным ");
}
if (number1 == 5)
{
    Console.WriteLine("День не является выходным ");
}
if (number1 == 6)
{
    Console.WriteLine("Да, этот день выходной ");
}
if (number1 == 7)
{
    Console.WriteLine("Да, этот день выходной");
}
if (number1 > 7)
{
    Console.WriteLine("Введите корректное число от 1 до 7");
}

