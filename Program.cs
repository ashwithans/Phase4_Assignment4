// See https://aka.ms/new-console-template for more information

using ConsoleAppAssignmentDay4;

SortedList<string, Product> products = new SortedList<string, Product>();

products.Add("Product1", new Product { ProductId = 1, PName = "Moisturizing Cream", PPrice = 350, PBrand = "Nivea", MfgDate = new DateTime(2022, 11, 12), ExpDate = DateTime.Now });
products["Product2"] = new Product { ProductId = 2, PName = "Lipstick", PPrice =999, PBrand = "Maybelline", MfgDate = new DateTime(2022, 11, 12), ExpDate = DateTime.Now };
products["Product3"] = new Product { ProductId = 3, PName = "Facial Mask", PPrice = 150, PBrand = "L'Oréal", MfgDate = new DateTime(2022, 11, 12), ExpDate = DateTime.Now };
products["Product4"] = new Product { ProductId = 4, PName = "Eyeliner", PPrice = 250m, PBrand = "Revlon", MfgDate = new DateTime(2023, 11, 12), ExpDate = DateTime.Now };
products["Product5"] = new Product { ProductId = 5, PName = "Shampoo", PPrice = 180, PBrand = "Pantene", MfgDate = new DateTime(2023, 11, 12), ExpDate = DateTime.Now };
products["Product6"] = new Product { ProductId = 6, PName = "Perfume", PPrice = 4500, PBrand = "Calvin Klein", MfgDate = new DateTime(2021, 11, 12), ExpDate = DateTime.Now };
products["Product7"] = new Product { ProductId = 7, PName = "Hair mask", PPrice = 650, PBrand = "Tressemme", MfgDate = new DateTime(2021, 11, 12), ExpDate = DateTime.Now };

Console.WriteLine("ID\tName\t\t\tBrand\t\tMfg Date");

foreach (var product in products.Values)
{
    Console.Write(product.ProductId + "\t \t");
    Console.Write(product.PName + "\t \t");
    Console.Write(product.PBrand + "\t \t");
    Console.Write(product.MfgDate.ToLongDateString());
    Console.WriteLine("\n");
}

