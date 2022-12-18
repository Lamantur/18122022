// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.

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


int sizen = Prompt("Введите размер матрицы");

int[,] array = new int[sizen, sizen];

int sizem = sizen;
int element = 0;
int i = 0;
int j = 0;
int ring = 0;
while (element <= sizen * sizen - 2)
{
    while (j < sizem - 1)
    {
        array[i, j] = element + 1;

        j++;
        element++;
    }
    while (i < sizem - 1)
    {
        array[i, j] = element + 1;
        element++;
        i++;
    }
    while (j > ring)
    {
        array[i, j] = element + 1;

        j--;
        element++;
    }
    while (i > ring)
    {
        array[i, j] = element + 1;
        element++;
        i--;
    }
    i++;
    j++;
    sizem--;
    ring++;

}
if (sizen % 2 != 0) array[i, j] = sizen * sizen;

PrintArrayTwo(array);