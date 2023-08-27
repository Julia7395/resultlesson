// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int lastnambers(int numb)
{
   int lastnambers = numb/100 % 10;
   return lastnambers;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int lastnumber = lastnambers(number);
Console.WriteLine("result");
{  
if (lastnumber == number/100 % 10) Console.WriteLine("lastnumber");
else Console.WriteLine("Третьего числа нет");
}

