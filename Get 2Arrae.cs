/*
задача 54

Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
Get2DArray(matrix);
Console.WriteLine();
Console.WriteLine("Исходный массив");
PrintArray(matrix);

for (int i = 0; i <matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0;k< matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1]) 
            {
                int temp = 0;
                temp = matrix[i,k];
               matrix[i,k] = matrix[i, k+ 1];
                matrix[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Измененный массив");
PrintArray(matrix);

void Get2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/

/*
задача 56
*/
Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[rows,columns ];
Get2DArray(matrix);
PrintArray(matrix);
int minsum = Int32.MaxValue;
int rowsIndex = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
       rowsIndex++;
    }
}

void Get2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.WriteLine("Номер строки с наименьшей суммой: " + (rowsIndex));
