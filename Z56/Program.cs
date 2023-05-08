// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
// ArrangeArray(array);
// PrintArray(array);
System.Console.WriteLine(FindInArray(array));

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
// Найти номер строчки с минимальной суммой
int FindInArray(int[,] matrix)
{
    int[] temp=new int{matrix.GetLength(0)};
    int sum=0;
    int number=-1;
    for (int i = 0; i < temp.Length; i++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum =sum+matrix[i,j];
                }
        }
        temp[i] = sum;
        for (int i = 0; i < temp.Length-1; i++)
        {
            int tempo=0;
            int min = 0;
            if temp[min]>temp[i+1]
            {
                tempo = temp[i+1];
                temp[i]= temp[min];
                temp[i+1]= tempo;
                min = i;
            }
            return number;
        }
        
    }
}