// See https://aka.ms/new-console-template for more information
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[,] arraytwo = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < arraytwo.GetLength(0); i++)
{
    for (int j = 0; j < arraytwo.GetLength(1); j++)
    {
        arraytwo[i, j] = random.Next(0, 10);
        Console.Write(arraytwo[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] result = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < arraytwo.GetLength(1); j++)
    {
        result[i, j] = array[i,j] * arraytwo[i,j];
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}