using System.Data;

namespace LinqPractice
{
    class MainApp
    {
        class Inventory
        {
            public string? Product { get; set; }
            public int Count { get; set; }
        }

        class Goods
        {
            public string? Product { get; set; }
            public int Price { get; set; }
        }

        static void Main(string[] args)
        {
            // 1. LINQ Basic (from, where, orderby, select)
            int[] numbers = { 9, 2, 8, 7, 6, 5, 4, 3, 2, 11 };
            var result = from n in numbers
                         where n % 2 == 0
                         orderby n descending
                         select n;
            foreach (var n in result) {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            var result2 = numbers.Where(n => n % 2 == 0)
                                 .OrderByDescending(n => n)
                                 .Select(n => n);
            foreach (var n in result2) {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            /*
                8
                6
                4
                2
                2
            */

            // 1-2. select new()
            Inventory[] fruitStore =
            {
                new Inventory(){Product="Grape", Count=8},
                new Inventory(){Product="Pear", Count=5},
                new Inventory(){Product="Strawberry", Count=9},
                new Inventory(){Product="Blueberry", Count=50},
                new Inventory(){Product="Persimmon", Count=14},
                new Inventory(){Product="Apple", Count=3}
            };
            var fruitCheck = from fruits in fruitStore
                             where fruits.Count < 10
                             orderby fruits.Product
                             select new
                             {
                                 Name = fruits.Product,
                                 Required = 10 - fruits.Count
                             };
            foreach (var fruit in fruitCheck){
                Console.WriteLine($"{fruit.Name} : + {fruit.Required}");
            }
            Console.WriteLine();

            var fruitCheck2 = fruitStore.Where(fruits => fruits.Count < 10)
                                        .OrderBy(fruits => fruits.Product)
                                        .Select(fruits => new
                                        {
                                            Name = fruits.Product,
                                            Required = 10 - fruits.Count
                                        });
            foreach (var fruit in fruitCheck2) {
                Console.WriteLine($"{fruit.Name} : + {fruit.Required}");
            }
            Console.WriteLine();

            /*
                Apple : + 7
                Grape : + 2
                Pear : + 5
                Strawberry : + 1
            */

            // 1-3. join
            Goods[] fruitSeller =
            {
                new Goods(){Product="Grape", Price=5000},
                new Goods(){Product="Pear", Price=7000},
                new Goods(){Product="Strawberry", Price=3000},
                new Goods(){Product="Blueberry", Price=1000},
                new Goods(){Product="Persimmon", Price=4000},
                new Goods(){Product="Apple", Price=3500}
            };
            var fruitPrice = from store in fruitStore
                             join seller in fruitSeller on store.Product equals seller.Product
                             where store.Product.Contains('r') && seller.Price <= 5000
                             orderby store.Product
                             select new
                             {
                                 Name = store.Product,
                                 RequiredCost = seller.Price * store.Count
                             };
            foreach (var fruit in fruitPrice) {
                Console.WriteLine($"{fruit.Name} ->  {fruit.RequiredCost} Won");
            }
            Console.WriteLine();

            /*
                Blueberry ->  50000 Won
                Grape ->  40000 Won
                Persimmon ->  56000 Won
                Strawberry ->  27000 Won
            */
        }
    }
}
