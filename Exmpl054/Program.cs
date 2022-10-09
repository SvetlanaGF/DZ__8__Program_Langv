// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Задача 54: Задать двумерный массив.");
Console.WriteLine("Каждую строку массива упорядочить по убыванию.");
//Console.WriteLine();

int [,] array = { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4} };
int countRow = array.GetLength(0);
int countColumn = array.GetLength(1);
int [] arrayI = new int [countColumn];

void OutPutArray2 (int [,] arr)
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

void OutPutArray1 (int [] arr1)
{
        for (int k = 0; k < countColumn; k++)
        {
            Console.Write($"\t" + arr1[k]);
        }
        Console.WriteLine();
}

void MetodSort (int [] arrI)
{
        Array.Sort(arrI);
        Array.Reverse(arrI);
        Console.WriteLine("Упорядочена по убыванию: ");
        OutPutArray1 (arrI);
}
    
OutPutArray2 (array);

for (int i = 0; i < countRow; i++)
{
    Console.WriteLine($"\nСтрока {i} задано: ");
    for (int j = 0; j < countColumn; j++)
    {
        arrayI [j] = array [i,j];
        Console.Write($"\t" + arrayI[j]);
    }
    Console.WriteLine();    
    MetodSort (arrayI);
}
Console.WriteLine(); 
