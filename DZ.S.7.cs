
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*Console.WriteLine("Введите число столбцов в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк в массиве");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив:");
Console.WriteLine();
double[,] Array = new double[m, n]; // Определяем массив вещественных чисел
for (int i = 0; i < m; i++) // строчки; 
{
    // i,j - индексы
    for (int j = 0; j < n; j++)// столбцы; 
    {
        Array[i, j] = new Random().NextDouble() * 100;///Заполняем 
        Console.Write(Array[i, j] + "\t");
    }
Console.WriteLine();}
*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1(строчка) 7 (столбец) -> такого числа в массиве нет
*/
/*int size1 = 4;
int size2 = 3;
Console.WriteLine("Введите позицию Х элемента в двумерном массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию Y элемента в двумерном массиве");
int n = Convert.ToInt32(Console.ReadLine());
if (size1 < m || size2 < n)// Проверка на нахождение введенных элементов номеров массива
{
    Console.WriteLine("Такого числа не существует в массиве");
}
Console.WriteLine();

int[,] Array = new int[size1, size2]; // Определяем массив 
for (int i = 0; i < size1; i++) // строчки; 
{
    for (int j = 0; j < size2; j++)// столбцы; 
    {
        int minValue = 0;
        int maxValue = 10;
        Array[i, j] = new Random().Next(minValue, maxValue + 1);
        Console.Write(Array[i, j] + "\t");
    }
    Console.WriteLine();
}
*/


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
double sum = 0;
double sum2 = 0;
double sum3 = 0;
int size1 = 4;
int size2 = 3;
double[,] Array = new double[size1, size2]; // Определяем массив 
for (int i = 0; i < size1; i++) // строчки; 
{
    for (int j = 0; j < size2; j++)// столбцы; 
    {
        int minValue = 0;
        int maxValue = 10;
        Array[i, j] = new Random().Next(minValue, maxValue + 1);
        Console.Write(Array[i, j] + "\t");
    }
    Console.WriteLine();
    sum = ((Array[0, 0] + Array[1, 0] + Array[2, 0] + Array[3, 0])) / 4;
    sum2 = ((Array[0, 1] + Array[1, 1] + Array[2, 1] + Array[3, 1])) / 4;
    sum3 = ((Array[0, 2] + Array[1, 2] + Array[2, 2] + Array[3, 2])) / 4;

    Console.WriteLine();
}
Console.WriteLine($"Первый столбец: {sum}, {"\t"} Второй столбец:{sum2}, {"\t"} Третий столбец:{sum3}");
Console.WriteLine();
