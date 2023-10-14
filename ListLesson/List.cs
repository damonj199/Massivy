// Задание 1

using System.Diagnostics;

Console.Write("Введите количество сотрудников: ");
int rating = int.Parse(Console.ReadLine());
List<int> ratings = new();

for (int i = 1; i <= rating; i++)
{
    Console.Write($"Введите рейтинг сотрудника № {i}: ");
    ratings.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine();
Console.WriteLine($"Наибольший рейтинг сотрудника: {ratings.Max()}");
Console.WriteLine();

//Задание 2

Console.Write("Количество поступивщих товаров: ");
int price = int.Parse(Console.ReadLine());
List<int> priceList = new();

for (int i = 1; i <= price; i++)
{
    Console.Write($"Укажите закупочную цену товара № {i} : ");
    priceList.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine();

for (int i = 0; i < price; i++)
{
    priceList[i] += priceList[i] * 18 / 100;

    Console.WriteLine($"Цена для продажи товара № {i+1} : {priceList[i]}");
}
Console.WriteLine();

// Задание 3

Console.Write("Количество работников: ");
int countStaff = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Укажите план продаж: ");
int plan = int.Parse(Console.ReadLine());

Console.WriteLine();

List<int> salesAmount = new();
int staff = 0;

for (int i = 1; i <= countStaff; i++)
{
    Console.Write($"Сумма продаж каждого сотрудника № {i}: ");
    salesAmount.Add(int.Parse(Console.ReadLine()));
}
Console.WriteLine();
for (int i = 0; i < countStaff; i++)
{
    if (salesAmount[i] < plan)
    {
        staff++;
    }
}
Console.WriteLine($"Cотрудников не выполнивших план: {staff}");