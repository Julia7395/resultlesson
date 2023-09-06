//  Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int DecimalToBin(int num)
{
    int res = 0;
    int factor = 1;
    while (num > 0)
    {
        res = res + num % 2 * factor;
        num /= 2;
        factor *= 10;
    }
    return res;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int decimalToBin = DecimalToBin(number);
Console.WriteLine(decimalToBin);