// See https://aka.ms/new-console-template for more information
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int q = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, q];
Random random = new Random();
for (int x = 0; x < array.GetLength(2); x++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j, x] = random.Next(0, 100);
            Console.Write(array[i, j, x] + $"({i},{j},{x})" + " ");
        }
        Console.WriteLine();
    }
}