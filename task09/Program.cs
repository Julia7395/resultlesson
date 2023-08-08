// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {number}");

// int firstDigit = number / 10; // 78/10 = 7,8 =7
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// // else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// решение с помощью функции
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num) // берем другое наименование в функции, не number, a num
{
  int firstDigit = num / 10; 
  int secondDigit = num % 10; 
  // if (firstDigit > secondDigit) return firstDigit;
  //return secondDigit; 
  int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
  return maxDigit;
}

// сокращенная версия кода: int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
// тернартный оператор (тройной) 14,15,16,17 строка