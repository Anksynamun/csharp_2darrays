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
int s = 0;
int[] newarray = new int[s];
for (int i = 0; i < array.GetLength(0); i++)
{
    int avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        avg += array[i, j];
    }
    newarray = newarray.Append(avg).ToArray();
}
int min = Array.IndexOf(newarray, newarray.Min());
Console.WriteLine(min + 1 + "-я строка");