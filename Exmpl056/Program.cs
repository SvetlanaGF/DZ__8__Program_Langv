// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Задача 56: Задать двумерный прямоугольный массив.");
Console.WriteLine("Найти строку с наименьшей суммой элементов.");

int [,] array = { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7} };
int countRow = array.GetLength(0);
int countColumn = array.GetLength(1);

void OutPutArrayTwoDimensional (int [,] arr) // вывод двумерного массива
{
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            Console.Write($"\t" + arr[i,j]);
        }
        Console.WriteLine();
    }
}

int MetodSumRow (int [,] arr, int i) // суммируем элементы i-й строки
{
    int SumRow = 0;
    for (int j = 0; j < countColumn; j++)
    {
        SumRow = SumRow + array [i,j];
    }
    return SumRow;
}

OutPutArrayTwoDimensional (array);

int minSumRow = MetodSumRow (array, 0);
int numberRow = 1;

    for (int i = 1; i < countRow; i++)
    {
        int tempSum = MetodSumRow (array, i);
        if (minSumRow > tempSum)
        {
            minSumRow = tempSum;
            numberRow = i+1;
        }
    }
Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {numberRow}.");
Console.WriteLine(); 