// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num, num1, sum=0, result;

Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (result = num; num != 0; num = num / 10)
    {
        num1 = num % 10;
        sum = sum * 10 + num1;
    }
    if (result == sum)
        Console.Write($"{result} является палиндромом");
    else
        Console.Write($"{result} не является палиндромом");
}
else
    Console.Write("Введите пятизначное число!");