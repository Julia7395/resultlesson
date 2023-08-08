// Напишие программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 - 46
int number = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {number}");

// int firstDigit = number / 100; 
// int lastDigit = number % 10;
// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine(result); 

int res2= twonambers(number);
Console.WriteLine(res2);

int twonambers (int num) 
{
  int firstDigit = num / 100; 
  int lastDigit = num % 10; 
  int result = firstDigit * 10 + lastDigit;
  return result;
}

