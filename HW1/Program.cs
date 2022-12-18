//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Получаем отдельную строку матрицы
int[] GetString(int[,] matrix, int stringN)
{
    int[] massiv = new int[matrix.GetLength(1)];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = matrix[stringN, i];
    }
    return massiv;
}

//Сортировка массива
int[] SortMassive(int[] nums)
{
    int temp;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] < nums[j])
            {
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
    return nums;
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
//Ввод данных
int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

//Собираем матрицу из строк

int m = Prompt("Введите количество строк для генерации массива >");
int n = Prompt("Введите количество столбцов >");
int[,] matrix = CreateFillArray(m, n);


int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = SortMassive(GetString(matrix, i))[j];
    }
}


System.Console.WriteLine("генерация матрицы:");
PrintArrayTwo(matrix);
System.Console.WriteLine("");
System.Console.WriteLine("_обработка_");
System.Console.WriteLine("");
PrintArrayTwo(array);
