// №1

// int[,] array = {
// { 1, 4, 7, 2 },
// { 5, 9, 2, 3 },
// { 8, 4, 2, 4 }
// };

// Console.WriteLine("Исходный массив:");

// PrintArray(array);

// SortRowsDescending(array);

// Console.WriteLine("\nУпорядоченный массив по убыванию элементов в каждой строке:");

// PrintArray(array);

// Console.ReadLine();

// void SortRowsDescending(int[,] array)
// {
// int rowCount = array.GetLength(0);
// int columnCount = array.GetLength(1);

// for (int row = 0; row < rowCount; row++)
// {
// for (int i = 0; i < columnCount - 1; i++)
// {
// for (int j = 0; j < columnCount - i - 1; j++)
// {
// if (array[row, j] < array[row, j + 1])
// {
// int temp = array[row, j];
// array[row, j] = array[row, j + 1];
// array[row, j + 1] = temp;
// }
// }
// }
// }}

// void PrintArray(int[,] array)
// {
// int rowCount = array.GetLength(0);
// int columnCount = array.GetLength(1);

// for (int row = 0; row < rowCount; row++)
// {
// for (int column = 0; column < columnCount; column++)
// {
// Console.Write(array[row, column] + " ");
// }
// }
// }


// №2

// int[,] array = {
// { 1, 4, 7, 2 },
// { 5, 9, 2, 3 },
// { 8, 4, 2, 4 }
// };

// int rowCount = array.GetLength(0);
// int columnCount = array.GetLength(1);

// int minSumRow = FindRowWithMinSum(array, rowCount, columnCount);

// Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");

// int FindRowWithMinSum(int[,] array, int rowCount, int columnCount)
// {
// int minSumRow = 0;
// int minSum = int.MaxValue;

// for (int row = 0; row < rowCount; row++)
// {
// int sum = 0;

// for (int column = 0; column < columnCount; column++)
// {
// sum += array[row, column];
// }

// if (sum < minSum)
// {
// minSum = sum;
// minSumRow = row;
// }
// }

// return minSumRow;
// }

// №3

// int[,] matrix1 = {
// { 2, 4, 3 ,4   },
// };

// int[,] matrix2 = {
// { 3, 2, 3 ,3   },
// };

// int[,] result = MultiplyMatrices(matrix1, matrix2);

// Console.WriteLine("Результат произведения матриц:");

// PrintMatrix(result);

// int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
// {
// int rows1 = matrix1.GetLength(0);
// int columns1 = matrix1.GetLength(1);
// int columns2 = matrix2.GetLength(1);

// int[,] result = new int[rows1, columns2];
// for (int i = 0; i < rows1; i++)
// {
// for (int j = 0; j < columns2; j++)
// {
// for (int k = 0; k < columns1; k++)
// {
// result[i, j] += matrix1[i, k] * matrix2[k, j];
// }
// }
// }

// return result;
// }
// void PrintMatrix(int[,] matrix)
// {
// int rows = matrix.GetLength(0);
// int columns = matrix.GetLength(1);
// for (int i = 0; i < rows; i++)
// {
// for (int j = 0; j < columns; j++)
// {
// Console.Write(matrix[i, j] + " ");
// }
// Console.WriteLine();
// }
// }


// №4

int[,,] array = new int[2, 2, 2];

int number = 10;

for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 2; j++)
{
for (int k = 0; k < 2; k++)
{
array[i, j, k] = number;
number++;
}
}
}

        
for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 2; j++)
{
for (int k = 0; k < 2; k++)
{
Console.WriteLine($"array[{i}][{j}][{k}] = {array[i, j, k]}");
}
}
}

// №5

// int[,] arry = new int[4, 4];
// int value = 1;

// int rowStart = 0, rowEnd = 3;
// int colStart = 0, colEnd = 3;

// while (rowStart <= rowEnd && colStart <= colEnd)
// {
            
// for (int col = colStart; col <= colEnd; col++)
// {
// arry[rowStart, col] = value++;
// }
// rowStart++;

            
//  for (int row = rowStart; row <= rowEnd; row++)
// {
// arry[row, colEnd] = value++;
// }
// colEnd--;

            
// if (rowStart <= rowEnd)
// {
// for (int col = colEnd; col >= colStart; col--)
// {
// arry[rowEnd, col] = value++;
// }
// rowEnd--;
// }


// if (colStart <= colEnd)
// {
// for (int row = rowEnd; row >= rowStart; row--)
// {
// arry[row, colStart] = value++;
// }
// colStart++;
// }
// }
// for (int row = 0; row < 4; row++)
        
// for (int col = 0; col < 4; col++)
// {
// Console.Write(arry[row, col] + "\t");
// }
