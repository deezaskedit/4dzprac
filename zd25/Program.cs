// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int DegreeOfNum(int number, int degree)
{
    int multi = number;
    for (int current = 1; current < degree; current ++)
        multi *= number;
    
    return multi;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int deg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DegreeOfNum(num, deg));
