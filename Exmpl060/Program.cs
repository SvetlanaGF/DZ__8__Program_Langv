// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int [,,] matrix = new int [2,2,2];
Random random = new Random();
int size1 = matrix.GetLength(0);
int size2 = matrix.GetLength(1);
int size3 = matrix.GetLength(2);
int newNumber;

//int [,,] matrix = new int [,,] {
                               //{ {66, 25}, {34, 41} },
                               //{ {27, 90}, {26, 55} }
                            //};

// Проверка, имеется ли уже такое число в массиве
bool MetodCheck(int [,,] array, int newNumb)
{
for (int i = 0; i < size1; i++)
{
    for (int j = 0; j < size2; j++)
    {
        for (int k = 0; k < size3; k++)
        {
            if (newNumb == matrix[i,j,k]) 
            {
                return false;
            }
        }
    }
}
return true;
}

for (int i = 0; i < size1; i++)
{
    for (int j = 0; j < size2; j++)
    {
int k = 0;
        while (k < size3)
        {
            newNumber = random.Next(10,100);
            if (MetodCheck(matrix, newNumber) == true)
            {
                matrix [i,j,k] = newNumber;
                k++;
            }
        }
    }
}

for (int i = 0; i < size1; i++)
{
    for (int j = 0; j < size2; j++)
    {
        for (int k = 0; k < size3; k++)
        {
            Console.Write(matrix[i,j,k] + $"({i},{j},{k}) \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
