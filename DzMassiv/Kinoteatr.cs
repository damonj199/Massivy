int[,] arrey = new int[2, 3];
int[] sumKino = new int[arrey.GetLength(0)];
int sum = 0;

for (int i = 0; i < arrey.GetLength(0); i++)
{
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        Console.WriteLine("Y: " + i + " X: " + j);
        arrey[i, j] = int.Parse(Console.ReadLine());
    }
}
    Console.WriteLine(sumKino[arrey.GetLength(0)-1]);

for (int i = 0; i < arrey.GetLength(1); i++)
{

    for (int j = 0; j < arrey.GetLength(0); j++)
    {
        sum += arrey[i,j];
    }

    for (int k = 0; k < arrey.GetLength(0); k++)
    {
        sumKino[k] = sum;
    }
    Console.WriteLine(sumKino[i]);
}