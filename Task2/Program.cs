int[,] arr = new int[5, 5];
Random random = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 20);
        Console.Write("{0,4}", arr[i, j]);
    }
    Console.WriteLine();
}
Console.Write("inter row   : ");
int row = int.Parse(Console.ReadLine());
Console.Write("inter col : ");
int col = int.Parse(Console.ReadLine());

int[] str = new int[5];

for (int i = 0; i < 5; i++)
{
    {
        str[i] = arr[row - 1, i];
    }
}

int[] find = new int[5];

for (int i = 0; i < col; i--)
{
    {
        find[i] = str[col - 1];
        Console.Write(find[i] + "  <=Find number");
    }
}