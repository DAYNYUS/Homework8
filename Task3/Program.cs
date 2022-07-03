// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы m : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов/строк первой/второй матриц n : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы p : ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] matrixFirst = new int[m, n];
FillArrayRandomNumbers(matrixFirst);
Console.WriteLine($"Первая матрица: ");
PrintArray(matrixFirst);
Console.WriteLine();

int[,] matrixSecond = new int[n, p];
FillArrayRandomNumbers(matrixSecond);
Console.WriteLine($"Вторая матрица: ");
PrintArray(matrixSecond);
Console.WriteLine();

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(matrixFirst, matrixSecond, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц: ");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] matrixFirst, int[,] matrixSecond, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixFirst.GetLength(1); k++)
      {
        sum += matrixFirst[i,k] * matrixSecond[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
