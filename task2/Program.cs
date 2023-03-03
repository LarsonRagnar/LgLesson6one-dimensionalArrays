// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a+b>c && a+c>b && b+c>a)
// {
// Console.WriteLine("Треугольние получился:)))) ");
    
// }
// else
// {
// Console.WriteLine("Треугольние НЕ получился:((( ");
// }

             //короткий метод
// bool IsTrinagle(int a, int b, int c)
// {
//     return (a+b>c && a+c>b && b+c>a);
// }
// Console.WriteLine(IsTrinagle(a,b,c));

// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.WriteLine("Введите чсколько чисел фибоначи надо вывести N ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(N);
// int[] FillArray(int N)
// {
//     int[] result = new int[N];
//     result[0]=0;
//     result[1]=1;

//     for (int i = 2; i < N; i++)
//     {
//         result[i] = result[i-1] + result[i-2];
//     }
//     return result;
// }
// Console.WriteLine($"Фибоначи: {string.Join("; ", array)}");

             //



// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array =new int[];
int[] Binary(int inputNumber)
{

} 