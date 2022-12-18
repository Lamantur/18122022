//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//                   Теория
// Формула для элементов произведения матриц
//     с[i, j] = сумма(a[i, r] * b[r, j])
//Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В .
//В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В .

// Генерация случайной матрицы размером mХn
int[,] CreateFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

//Произведение двух матриц
int[,] MatrixPower(int[,] A, int[,] B)
{
    int[,] array = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int r = 0; r < B.GetLength(1); r++)
            {
                array[i, j] = array[i, j] + (A[i, r] * B[r, j]);
            }

        }
    }
    return array;
}

//Ввод данных
int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
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

int[,] matrixA = CreateFillArray(Prompt("Введите количество строк первой матрицы: "), Prompt("Введите количество столбцов первой матрицы = количество строк второй: "));
int[,] matrixB = CreateFillArray(Prompt("Введите количество строк второй матрицы: "), matrixA.GetLength(1));
int[,] matrixC = MatrixPower(matrixA, matrixB);

PrintArrayTwo(matrixA);
System.Console.WriteLine("X");
PrintArrayTwo(matrixB);
System.Console.WriteLine("=");
PrintArrayTwo(matrixC);