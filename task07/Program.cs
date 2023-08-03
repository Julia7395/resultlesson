// Принимает на вход трехзначное число и на выход показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Ввведитен трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number%10;
Console.WriteLine($"Последняя цифра {lastDigit}");