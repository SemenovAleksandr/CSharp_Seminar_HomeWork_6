// Задача 39: Напишите программу,
// которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Метод заполнения массива
// int[] GetArray(int size, int minRandom, int maxRandom)
// {
// int[] result = new int[size];
// for (int i =0; i < result.Length; i++)
// {
//     result[i] = new Random(). Next(minRandom, maxRandom +1);
// }
// return result;
// }

// // Метод переворота массива
// int[] CopyArray(int [] inputArray)

// {
//     int[] arrayCopy = new int[inputArray.Length];
//     int lastIndex = inputArray.Length -1;
//     for (int i = 0; i < arrayCopy.Length; i++)
//     {
//         arrayCopy[i] = inputArray[lastIndex-i];
//     }
//     return arrayCopy;
// }

// // Метод пузырька
// void ReverseArray (int[] inputArray)
// {
//     for (int i = 0; i < inputArray.Length /2; i++)
//     {
//         int temp = inputArray[i];
//         inputArray[i] = inputArray[inputArray.Length -1 - i];
//         inputArray[inputArray.Length -1 - i] = temp;
//     }
// }

// int [] array = GetArray(10, 0, 10);
// Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");

// int [] reversedArray = CopyArray(array);
// Console.WriteLine($"Массив перевернутый: [ {String.Join(", ", reversedArray)} ]");

// ReverseArray(array);
// Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число C");
// int C = Convert.ToInt32(Console.ReadLine());

// if ( (A<(B+C)) && (B<(A+C)) && (C<(A+B)) ) Console.WriteLine("Треугольник существует");
// else Console.WriteLine("Треугольник не существует");

// Решение через метод

// bool IsTriangle(int A, int B, int C)
// {
//     return ((A<(B+C)) && (B<(A+C)) && (C<(A+B)));

// }
// Console.WriteLine(IsTriangle(100,4,5));


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Вариант решения 1 - через массив
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];

// array[0] = 0;
// array[1] = 1;
// Console.WriteLine(array[0]);
// Console.WriteLine(array[1]);

// for (int i = 2; i <= n; i++)
// {
//     array[i] = array[i-1]+array[i-2];
//     Console.WriteLine(array[i]);
// }

// Вариант решения 2

// int N = Convert.ToInt32(Console.ReadLine());

// int firstNumber = 0;
// int secondNumber = 1;


// if (N<2) return;
// Console.WriteLine(firstNumber);
// Console.WriteLine(secondNumber);

// for (int i = 3; i <= N; i++)
// {
//     int nextNumber = firstNumber + secondNumber;
//     Console.WriteLine(nextNumber);
//     firstNumber = secondNumber;
//     secondNumber = nextNumber;
// }

//Console.WriteLine("test");

// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Решается через метод Copyarray аналогично задаче 39.

//Домашняя работа.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число М:");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = 0;

for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] >0) count +=1;
}
Console.WriteLine($"Пользователь ввёл массив: {String.Join(", ", array)}");
Console.WriteLine($"Массив содержит {count} чисел больше 0");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите число b1: ");
// float b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число k1: ");
// float k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число b2: ");
// float b2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число k2: ");
// float k2 = Convert.ToInt32(Console.ReadLine());

// float x = (b2-b1)/(k1-k2);
// float y = k1*x + b1;

// Console.WriteLine($"Точка пересечения прямых: ( {x}; {y}) ");




