using System;
using System.Linq;
using System.Text;

namespace WarehouseApp
{
    struct Product
    {
        public string Name;
        public string Code;
        public string Manufacturer;
        public decimal PurchasePrice;
        public decimal Markup;

        public decimal RetailPrice => PurchasePrice * (1 + Markup / 100);

        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Код: {Code}, Производитель: {Manufacturer}, Закупочная цена: {PurchasePrice:C}, Наценка: {Markup}%, Розничная цена: {RetailPrice:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool continueProgram = true;
            try
            {
                while (continueProgram)
                {
                    Console.Write("Начать работу программы? (Y/N): ");
                    string startResponse = Console.ReadLine();

                    if (startResponse.ToUpper() == "Y")
                    {
                        Product[] products = FillProducts();

                        Console.WriteLine("Введите максимальную цену для уценки:");
                        decimal maxPriceForDiscount;
                        while (!decimal.TryParse(Console.ReadLine(), out maxPriceForDiscount))
                        {
                            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
                        }

                        products = DiscountProducts(products, maxPriceForDiscount);

                        var sortedProducts = SortProductsByRetailPrice(products);

                        Console.WriteLine("Товары в порядке возрастания розничной цены:");
                        foreach (var product in sortedProducts)
                        {
                            product.PrintInfo();
                        }
                    }
                    else if (startResponse.ToUpper() == "N")
                    {
                        continueProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Пожалуйста, введите Y или N.");
                    }
                }
            }
            catch (FormatException fe) { Console.WriteLine(fe.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        static Product[] FillProducts()
        {
            Product[] products = new Product[5];
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Введите данные для товара {i + 1}:");
                products[i] = new Product
                {
                    Name = PromptNonEmptyString("Название: "),
                    Code = PromptNonEmptyString("Код: "),
                    Manufacturer = PromptNonEmptyString("Производитель: "),
                    PurchasePrice = PromptDecimal("Закупочная цена: "),
                    Markup = PromptDecimal("Наценка (%): ")
                };
            }
            return products;
        }

        static string PromptNonEmptyString(string message)
        {
            string value;
            do
            {
                Console.Write(message);
                value = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите непустую строку.");
                }
            } while (string.IsNullOrWhiteSpace(value));
            return value;
        }

        static decimal PromptDecimal(string message)
        {
            decimal value;
            Console.Write(message);
            while (!decimal.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
                Console.Write(message);
            }
            return value;
        }

        static Product[] DiscountProducts(Product[] products, decimal maxPriceForDiscount)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].RetailPrice > maxPriceForDiscount)
                {
                    products[i].PurchasePrice *= 0.8m; // уценка на 20%
                }
            }
            return products;
        }

        static Product[] SortProductsByRetailPrice(Product[] products)
        {
            return products.OrderBy(p => p.RetailPrice).ToArray();
        }
    }
}
