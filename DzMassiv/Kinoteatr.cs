int[,] arrey = new int[30, 10];
Random r = new Random();

for (int i = 0; i < arrey.GetLength(0); i++)
{
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        //Console.WriteLine("Y: " + i + " X: " + j);
        //arrey[i, j] = int.Parse(Console.ReadLine());
        arrey[i, j] = r.Next(20);
    }
}

int[] sumKino = new int[arrey.GetLength(1)];

for (int i = 0; i < arrey.GetLength(1); i++)
{
    int sum = 0;

    for (int j = 0; j < arrey.GetLength(0); j++)
    {
        sum += arrey[j,i];
    }

    sumKino[i] = sum;
    Console.WriteLine($"Сумма простмотров фильма № {i+1} за месяц составляет: {sumKino[i]}");
}