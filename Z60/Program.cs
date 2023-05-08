
Console.Clear();

int i = num("1-ю длину массива");
int j = num("2-ю длину массива");
int h = num("3-ю длину массива");
int x = num("минимальное рандомное число");
int y = num("максимальное рандомное число");
// Создание массива с 
int[,,] array = new int[i, j, h];
FillArray(array, x, y + 1);
PrintArray(array);

// Выбор длин массива
int num(string u)
{
    System.Console.Write($"Введите {u}: ");
    return int.Parse(System.Console.ReadLine());
}

// Заполнение массива
void FillArray(int[,,] matrix, int a, int b)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int h = 0; h < matrix.GetLength(2); h++)
            {
                matrix[i, j, h] = new Random().Next(a, b);
            }
        }
    }
}

// Печать массива
void PrintArray(int[,,] matrix)
{
    for (int h = 0; h < matrix.GetLength(2); h++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j, h]}({i},{j},{h}) ");
            }
            System.Console.WriteLine();
        }
    }
}