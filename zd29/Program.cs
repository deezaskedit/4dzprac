// 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] AskArray()
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[size];
    Console.WriteLine($"Введите {size} numbers xd: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();    
}
ShowArray(AskArray());
