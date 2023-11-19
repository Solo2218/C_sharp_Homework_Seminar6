// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System.Runtime.Serialization.Formatters;

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetUserArray(size);
Console.WriteLine($"Количество чисел в массиве [{String.Join("; ", userArray)}] больше 0: {SumOfPositiveNumbers(userArray)}");

int[] GetUserArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

