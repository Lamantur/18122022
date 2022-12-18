//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Ввод данных
int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
// Генерация случайной матрицы размером mХn
int[,] CreateFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
//Сумма элементов строки из матрицы
int SummOfStringFromMatrix(int[,] Matrix, int stringN)
{
    int summ = 0;
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        summ = summ + Matrix[stringN, j];
    }
    return summ;
}

//Печать матрицы
void PrintArrayTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine("");
    }
}


int[,] Array = CreateFillArray(Prompt("Введите количество строк для генерации массива >"), Prompt("Введите количество столбцов >"));
int min = SummOfStringFromMatrix(Array, 0);
int mini = 1;
for (int i = 0; i < Array.GetLength(0); i++)
{
    if (SummOfStringFromMatrix(Array, i) < min) mini = i + 1;
}

System.Console.WriteLine("генерация матрицы:");
PrintArrayTwo(Array);
System.Console.WriteLine("");
System.Console.WriteLine("Cтрока с наименьшей суммой элементов:");
System.Console.WriteLine(mini);


