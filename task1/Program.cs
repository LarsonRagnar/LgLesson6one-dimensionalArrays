// Задача 39: Напишите программу, которая 
// перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = FillArray(10, 0, 10);
Console.WriteLine($"Исходный массив: {string.Join("; ", array)}");
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
Console.WriteLine();

int[] CopyArray(int[] inputArray)
{
    int size = inputArray.Length;
    int j = size - 1;
    int[] inverseArray = new int[size];
    for (int i = 0; i < size; i++, j--)
    {
        inverseArray[i] = inputArray[j];   //inverseArray[i] = inputArray[size-1 -i];
    }
    return inverseArray;
}

int[] resultArray = CopyArray(array);
Console.WriteLine($"Перевернутый массив: {string.Join("; ", resultArray)}");


// Метод пузырек с доп перемной

// void ReverseArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;

//     }
// }
// Console.WriteLine($"Переворот через метод void");
// ReverseArray(array);
// Console.WriteLine($"Перевернутый массив: {string.Join("; ", array)}");



void ReverseArray(int[] arr)
{   
    int j = arr.Length-1;
    for (int i = 0; i < arr.Length / 2; i++, j--)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;

    }
}
Console.WriteLine($"Переворот через метод void");
ReverseArray(array);
Console.WriteLine($"Перевернутый массив: {string.Join("; ", array)}");