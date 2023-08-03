// напишите программу, которая
// 1. на вход принимает число и
// 2. выдает  его квадрат
// 4 -> 16
// -3 -> 9
//  -7 -> 49

Console.WriteLine("Введитe целое число") ;
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number ;
Console.WriteLine($"Квадрат числа {number} = {square}") ;