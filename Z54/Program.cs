Console.Clear();

int i = num("1-ю длину массива");
int j = num("2-ю длину массива");
int x = num("минимальное рандомное число");
int y = num("максимальное рандомное число");
// Создание массива с 
int [,] array = new int [i,j];
FillArray(array,x,y+1);
PrintArray(array);
System.Console.WriteLine();
ArrangeArray(array);
PrintArray(array);


// Выбор длин массива
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

void ArrangeArray(int[,] matrix)
{
    int temp = matrix[0,0];
    int max = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            if (max<matrix[i,j+1])
            {
                max = matrix[i,j+1];
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,j+1];
                matrix[i,j+1] = temp;
            }
            else if ((matrix[i,j]<max)&&(matrix[i,j]<matrix[i,j+1]))
            {
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,j+1];
                matrix[i,j+1] = temp;
            }
        }
    }
}