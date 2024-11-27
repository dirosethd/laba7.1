using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public decimal TotalValue => Quantity * Price;

    public override string ToString()
    {
        return $"Наименование: {Name}, Изготовитель: {Manufacturer}, " +
               $"Год выпуска: {Year}, Количество: {Quantity}, " +
               $"Цена: {Price}, Общая стоимость: {TotalValue}";
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Товар 1", Manufacturer = "Изготовитель 1", Year = 2023, Quantity = 10, Price = 250.00m },
            new Product { Name = "Товар 2", Manufacturer = "Изготовитель 2", Year = 2022, Quantity = 5, Price = 150.00m },
            new Product { Name = "Товар 3", Manufacturer = "Изготовитель 3", Year = 2023, Quantity = 8, Price = 300.00m },
            new Product { Name = "Товар 4", Manufacturer = "Изготовитель 4", Year = 2024, Quantity = 4, Price = 400.00m }
        };

        int currentYear = DateTime.Now.Year;
        decimal totalCost = 0;

        Console.WriteLine("Товары, выпущенные в текущем году:\n");

        foreach (var product in products)
        {
            if (product.Year == currentYear)
            {
                Console.WriteLine(product);
                totalCost += product.TotalValue;
            }
        }

        Console.WriteLine($"\nОбщая стоимость всех товаров, выпущенных в {currentYear}: {totalCost}");
    }
}