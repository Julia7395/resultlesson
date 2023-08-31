// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbers(int num)
{
    int result = 0;
    while (num>0)
    {
        result+=num%10;
        num=num/10;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
// Console.WriteLine(SumNumbers(number));  
Console.WriteLine($"Сумма цифр в числе {number} = {result}");
