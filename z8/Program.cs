// =============Дополнительная задача с семинара. Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

Console.Clear();
Console.WriteLine("Задайте исходный массив:");
Console.Write("Введите количество строк в двумерном массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в двумерном массиве: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SortMinToMax(array);
PrintArray(array);

void SortMinToMax(int[,] array)                            //метод сортировки двумерного массива по возрастанию (нечетные стоблцы)
{
    for (int j = 1; j < array.GetLength(1); j=j+2)
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            int minPosition = i;
            for (int k = i + 1; k < array.GetLength(0); k++)
            {
                if (array[k,j] < array[minPosition,j]) minPosition = k;
            }
            int temporary = array[i,j];
            array[i,j] = array[minPosition,j];
            array[minPosition,j] = temporary;
        }
    }
}




// // ================ Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.Clear();
// Console.WriteLine("Задайте исходный массив:");
// Console.Write("Введите количество строк в двумерном массиве: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов в двумерном массиве: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// SortMaxToMin(array);
// PrintArray(array);

// void SortMaxToMin(int[,] array)                            //метод сортировки двумерного массива по убыванию (строки)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int maxPosition = j;
//                 for (int k = j + 1; k < array.GetLength(1); k++)
//                 {
//                     if (array[i, k] > array[i, maxPosition]) maxPosition = k;
//                 }
//             int temporary = array[i, j];
//             array[i, j] = array[i, maxPosition];
//             array[i, maxPosition] = temporary;
//         }
//     }
// }






// // ================== Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// Console.Write("Задайте количество строк в двумерном массиве: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Задайте количество столбцов в двумерном массиве: ");
// int columns = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Исходный массив [{rows},{columns}]:\n");
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[] sumArray = SumArray(array);
// Console.WriteLine($"\nНаименьшая сумма элементов в {MinIndex(sumArray) + 1}-й строке");       //здесь +1, потому что счет строк начинается с первой, а элементы массива с 0.

// int MinIndex(int[] array)                                   //метод нахождения индекса минимального значения в одномерном массиве
// {
//     int min = array[0];
//     int minIndex = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             minIndex = i;
//         }
//     }
//     return minIndex;
// }

// int[] SumArray(int[,] array)                                //метод ссумирования значений в строке. Возвращает одномерный массив значений этих сумм строк
// {
//     int[] SumArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ += array[i, j];
//         }
//         Console.WriteLine($"Сумма {i + 1}-й строки: {summ}");
//         SumArray[i] = summ;
//     }
//     return SumArray;
// }







// // =================== Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.Clear();
// int rows1 = 2;
// int columns1 = 2;
// Console.WriteLine($"Первая матрица [{rows1},{columns1}]:");
// int[,] matr1 = GetArray(rows1, columns1, 0, 10);
// PrintArray(matr1);
// int rows2 = 2;
// int columns2 = 2;
// Console.WriteLine($"\nВторая матрица [{rows2},{columns2}]:");
// int[,] matr2 = GetArray(rows2, columns2, 0, 10);
// PrintArray(matr2);
// Console.WriteLine("\nМатрица переумножения равна:");
// int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
// matr3 = GetMatr3(matr3);
// PrintArray(matr3);

// int[,] GetMatr3(int[,] array)
// {
// int x=0, y=0, i=0, j=0, m=0, n=0;
//     array[x, y] = matr1[i, j] * matr2[m, n] + matr1[i, j + 1] * matr2[m + 1, n];
//     array[x, y + 1] = matr1[i, j] * matr2[m, n + 1] + matr1[i, j + 1] * matr2[m + 1, n + 1];
//     array[x + 1, y] = matr1[i + 1, j] * matr2[m, n] + matr1[i + 1, j + 1] * matr2[m + 1, n];
//     array[x + 1, y + 1] = matr1[i + 1, j] * matr2[m, n + 1] + matr1[i + 1, j + 1] * matr2[m + 1, n + 1];
// return array;
// }





// // ====================== Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

// Console.Clear();
// Console.WriteLine("Трехмерный массив 3x3x3: ");
// int[,,] MyArray = GetArray3(3, 3, 3, 10, 100);
// PrintArray3(MyArray);

// bool GetValue(int number, int[,,] array)    //метод нахождения числа в массиве
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             for (int c = 0; c < array.GetLength(2); c++)
//             {
//                 if (number == array[a, b, c])
//                 {
//                     return true;
//                 }
//             }
//         }
//     }
//     return false;
// }

// int[,,] GetArray3(int a, int b, int c, int minValue, int maxValue)          //метод заполнения трехмерного массива неповторяющимися двухзначными числами
// {
//     int[,,] result = new int[a, b, c];   
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(2); k++)
//             {
//             Link1:
//                 int random = new Random().Next(minValue, maxValue);
//                 GetValue(random, result);
//                 if (GetValue(random, result) == true)
//                 { goto Link1; }
//                 result[i, j, k] = random;
//             }
//         }
//     }
//     return result;
// }

// void PrintArray3(int[,,] array)                               //метод вывода трехмерного массива на печать
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                  Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");    //построчный вывод массива с индексами
//             }
//         }
//         Console.WriteLine();
//     }
// }






// // ============== Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// Console.Clear();
// string[,] array = new string[4, 4];
// Spiral(array);
// PrintArrayString(array);

// string[,] Spiral(string[,] array)
// {

//     for (int j = 0, i = 0, k = 1; j < array.GetLength(1); j++, k++)
//     {
//         string a = Convert.ToString(k);
//         array[i, j] = "0" + a;
//     }

//     for (int i = 1, j = 3, k = 5; i < array.GetLength(0); i++, k++)
//     {
//         string a = Convert.ToString(k);
//         array[i, j] = "0" + a;
//     }

//     for (int j = 2, i = 3, k = 8; j >= 0; j--, k++)
//     {
//         string a = Convert.ToString(k);
//         array[i, j] = "0" + a;
//     }

//     for (int i = 3, j = 0, k = 10; i > 0; i--, k++)
//     {
//         string a = Convert.ToString(k);
//         array[i, j] = a;
//     }

//     for (int j = 1, i = 1, k = 13; j < 3; j++, k++)
//     {
//         string a = Convert.ToString(k);
//         array[i, j] = a;
//     }

//     array[2, 2] = "15";
//     array[2, 1] = "16";

//     return array;
// }

// void PrintArrayString(string[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }










int[,] GetArray(int m, int n, int minValue, int maxValue)   //метод создания и заполнения двумерного массива рандомными числами 
{
    int[,] result = new int[m, n];                          
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)                    //метод вывода двумерного массива на печать
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}






