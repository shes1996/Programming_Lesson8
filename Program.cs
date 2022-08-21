// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void Zadacha54()
{
    int[ , ] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
    };
    int str = 3;
    int column = 4;
    int max;
    int temp;

    for (int i = 0; i < str; ++i)
    {
        for (int k = 0; k < column - 1; ++k)
        {
            for (int j = column - 1; j > 0; --j)
            {
                
                if (array[i,j]>array[i,j-1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j-1];
                    array[i,j-1] = temp;
                }
            }
        }
    }
    for (int i = 0; i < str; ++i)
    {
        for (int j = 0; j < column; ++j)
        {
            Console.Write(array[i,j] + " ");

        }
        Console.WriteLine();
    }
}
//Zadacha54();



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Zadacha56()
{
    int[ , ] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
        {5, 2, 6, 7},
        {1, 4, 3, 1}
    };
    int str = 5;
    int column = 4;
    int sum = 0;
    int min = 0;
    int n_str = 0;

    for (int j = 0; j < column; ++j)
        {
            min += array[0,j];

        }
    for (int i = 1; i < str; ++i)
    {   
        sum = 0;
        for (int j = 0; j < column; ++j)
        {
            sum += array[i,j];

        }
        if (min > sum)
        {
            min = sum;
            n_str = i;
        }
        
    }
    Console.WriteLine("   Наименьшая сумма соответствует строке {0}: {1}", n_str + 1, min);
}
//Zadacha56();

// Задача 58. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void Zadacha58()
{
    int[,] array = new int[4,4];
    Spiral(ref array);
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void Spiral(ref int[,] arr)
{
    int n = arr.GetLength(0);
    int count = n;
    int value = -n;
    int sum = -1;
    int k = 1;

    do
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            arr[sum / n, sum % n] = k;
            k++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            arr[sum / n, sum % n] = k;
            k++;
        }
    } while (count > 0);
}
Zadacha58();
