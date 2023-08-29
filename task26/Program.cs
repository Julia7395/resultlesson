// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 - 3
// 78 -2
// 89126 -5

int QuantityNumbers(int num)
{
   if (num == 0) return 1;
   int count = 0;
   while (num != 0)
   {
     num = num / 10;
     count++;
   }
    return count;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = QuantityNumbers(number);
Console.WriteLine(QuantityNumbers(number));  
