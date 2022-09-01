// 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int number)
{
    int current = number;
    int digits = 0;
    int sum = 0;
    while (current > 0)
    {
        sum = (current % 10) + sum;
        current = current / 10;
        digits ++;
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(num));
