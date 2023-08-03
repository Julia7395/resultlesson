// напишите программу
// 1. на вход принимает два числа
// 2. проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> yes 
// a = 2, b = 10 -> no
// a = 9, b = 3 -> yes
// a = -3, b = 9 -> no

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1/number2 == number2)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет"); 
}
 

