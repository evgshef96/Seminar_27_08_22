// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] GetArray(int rows, int columns, double max, double min)
{
    double[,] array = new double[rows,columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f2} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение элемента: ");
double min = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение элемента: ");
double max = double.Parse(Console.ReadLine()!);
double[,] array = GetArray(rows,columns,max,min);

PrintArray(array);