int[] a = Generete(10, 0, 100);
WriteSales(a);
a = SortMenu(a);
WriteSales(a);


int[] SortMenu(int[] numberOfSales)
{
    for(int i = 0; i < numberOfSales.Length-1; i++)
    {
        int maxIndex = i;
        for (int j = i; j < numberOfSales.Length; j++)
        {
            if (numberOfSales[j] > numberOfSales[maxIndex])
            {
                maxIndex = j;
            }
        }
        int tmp = numberOfSales[maxIndex];
        numberOfSales[maxIndex] = numberOfSales[i];
        numberOfSales[i] = tmp;
    }
    return numberOfSales;
}

void WriteSales(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Generete (int n, int minValue, int maxValue)
{
    int[] array = new int[n];

    Random random = new Random();

    for(int i = 0; i < n; i++)
    {
        array[i] = random.Next(minValue, maxValue+1);
    }
    return array;
} 