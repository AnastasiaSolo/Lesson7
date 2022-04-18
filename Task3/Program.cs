Console.Write("inter row   : ");
int row = int.Parse(Console.ReadLine());
Console.Write("inter coll : ");
int coll = int.Parse(Console.ReadLine());

int[,] array = new int[row, coll];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
for(int i = 0; i < row; i++)
{
    int Avg = 0;
    for(int x = 0; x < row; x++)
    {
        Console.Write(array[x, i] + " ");
        Avg += array[x, i];
    }
    Avg = Avg / row;
    Console.Write("Average is " + Avg );
     Console.WriteLine();
    Console.WriteLine("Clik enter ");
    Console.ReadLine();
}
