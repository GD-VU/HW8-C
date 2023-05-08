
Console.Clear();

System.Console.WriteLine("Перемножение двух матриц 2х2!");
int x = num("минимальное рандомное число");
int y = num("максимальное рандомное число");
// Создание массива с 
int [,] matrix1 = new int [2,2];
int [,] matrix2 = new int [2,2];
FillArray(matrix1,x,y+1);
FillArray(matrix2,x,y+1);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();
newMatrix(matrix1, matrix2);

// Функция ввода переменных
int num(string u)
{
    System.Console.Write($"Введите {u}: ");
    return int.Parse(System.Console.ReadLine());
}

// Заполнение массива
void FillArray(int[,] matrix, int a, int b)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(a,b);
        }
    }
}

// Печать массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

// Перемножение матриц
void newMatrix(int[,] array, int[,] matrix)
{
    int[,] result = new int[2, 2];
    result[0, 0] = array[0, 0] * matrix[0, 0] + array[0, 1] * matrix[1, 0];
    result[0, 1] = array[0, 0] * matrix[0, 1] + array[0, 1] * matrix[1, 1];
    result[1, 0] = array[1, 0] * matrix[0, 0] + array[1, 1] * matrix[1, 0];
    result[1, 1] = array[1, 0] * matrix[0, 1] + array[1, 1] * matrix[1, 1];
    System.Console.WriteLine($"{result[0, 0]} {result[0, 1]}");
    System.Console.WriteLine($"{result[1, 0]} {result[1, 1]}");

}
