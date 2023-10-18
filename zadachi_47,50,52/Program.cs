// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
int m = 3, n = 4;
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = (double)rand.Next(-100, 100) / 10;
        Console.Write(array[i, j] + "\t");
    }
Console.WriteLine();
}


// Задача 50: Напишите программу, которая на входпринимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.Clear();
int m = 3;
int n = 3;
int[,] arr = new int[m, n];
Console.Write("Введите значение: ");
int number = Convert.ToInt32(Console.ReadLine());
FillArray(arr);
FindElementArray(arr, number);

void FillArray(int[,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] findelemet, int usernumber)
{
    bool find = false;
    for (int i = 0; i < findelemet.GetLength(0); i++)
    {
        for (int j = 0; j < findelemet.GetLength(1); j++)
        {
            if (findelemet[i, j] == usernumber)
                Console.WriteLine("Ваше значение находится по координатам " + i + " " + j);
            find = true;
        }
    }
    if (!find)
        Console.WriteLine("Такого значения в масииве нет");
}


// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
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