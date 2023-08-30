// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 - 24
// 5 - 120

int multiplicationNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
         mult *= i; // mult = mult * i;   
        }

    }
    return mult;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = multiplicationNumbers(number);
// Console.WriteLine(SumNumbers(number));  
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");