// See https://aka.ms/new-console-template for more information
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            if (array[i,k] < array[i, k + 1])
            {
                int temporary = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i,k] = temporary;
            }
        }        
    }
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}