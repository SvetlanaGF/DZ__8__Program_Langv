// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();
Console.WriteLine("Задача 58: Задать две матрицы и найти их произведение.");

int [,] matrix1 = { {2, 4}, {3, 2} };
int [,] matrix2 = { {3, 4}, {3, 3} };
int countRow1 = matrix1.GetLength(0);
int countColumn1 = matrix1.GetLength(1);
int countRow2 = matrix2.GetLength(0);
int countColumn2 = matrix2.GetLength(1);
int [,] resultMatrix = new int [countRow1,countColumn2];

void OutPutArrayTwoDimensional (int [,] arr, int countRow, int countColumn)
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

Console.WriteLine ("Матрица 1:");
OutPutArrayTwoDimensional (matrix1,countRow1,countColumn1);
Console.WriteLine ("Матрица 2:");
OutPutArrayTwoDimensional (matrix2,countRow2,countColumn2);


if (countColumn1 != countRow2) 
Console.WriteLine ("Перемножение матриц невозможно: матрицы несогласованы.");
else
{
    for (int i = 0; i < countRow1; i++)
    {
        for (int j = 0; j < countColumn2; j++)
        {
            for (int k = 0; k < countColumn1; k++)
            {
                resultMatrix [i,j] += matrix1 [i,k] * matrix2 [k,j];
            }
        }
    }
}
Console.WriteLine ("Произведение двух матриц:");
OutPutArrayTwoDimensional (resultMatrix, countRow1, countColumn2);