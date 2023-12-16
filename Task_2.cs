using System;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int[] array)
    {
        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }

    public int[,] Add(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        return result;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        MathOperations mathOps = new MathOperations();

        Console.WriteLine(mathOps.Add(5, 10));
        
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine(mathOps.Add(array));

        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };
        int[,] resultMatrix = mathOps.Add(matrixA, matrixB);
    }
}
