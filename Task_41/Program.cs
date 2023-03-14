// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

CreateArray(array);
PrintArray(array);
int aboveZero = AboveZero(M);
Console.WriteLine($"Количество чисел больше 0 равно {aboveZero}");

void CreateArray(int[] arr)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите элемент {i} массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int AboveZero(int num)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}