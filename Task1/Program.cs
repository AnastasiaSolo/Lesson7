Console.Write("inter m   : ");
int m = int.Parse(Console.ReadLine());
Console.Write("inter n : ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
}
