using Exercise_3;
using System;
using System.Collections.Generic;

class Program
{
    static Product CreateNewProduct()
    {
        Product product = null;
        Console.WriteLine("Enter Product Type (1.Clothing - 2.Electronic) : ");
        var input = Console.ReadLine();
        int productType = int.TryParse(input, out int type) ? type : 0; 
        if (productType != 1 && productType != 2)
        {
            throw new Exception("You Entered Wrong Product Type!");
        }
        else
        {
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price : ");
            decimal price = decimal.TryParse(Console.ReadLine(), out decimal p) ? p 
                : throw new Exception("Invalid Product Price!");

            if (productType == 1)
            {
                Console.WriteLine("Enter Product Material : ");
                string material = Console.ReadLine();
                Console.WriteLine("Enter Product Size : ");
                string size = Console.ReadLine();
                product = new Clothing(name, price, size, material);
            }
            else if (productType == 2)
            {
                Console.WriteLine("Enter Product Warranty Period : ");
                int warranty = int.TryParse(Console.ReadLine(), out int w) ? w 
                    : throw new Exception("Invalid Product Warranty Period!");

                product = new Electronic(name, price, warranty);
            }
        }

        if (product is IDiscountable discountable)
        {
            Console.WriteLine("Enter Product Discount Percent : ");
            decimal discount = decimal.TryParse(Console.ReadLine(), out decimal d) ? d
                : throw new Exception("Invalid Product Discount Percent!");

            discountable.ApplyDiscount(discount);
        }

        if (product == null)
        {
            throw new Exception("Product creation failed!");
        }
        
        return product;
    }

    static void AddNewProduct(List<Product> products)
    {
        Product newProduct = CreateNewProduct();
        products.Add(newProduct);
    }

    static string ShowDetails(List<Product> products,string productName)
    {
        Product product = products.FirstOrDefault(p => p.Name == productName) 
            ?? throw new Exception("Product Not Found!");
        return product.GetProductDetails();
    }
    
    static void Main()
    {
        List<Product> products = new List<Product>();
        bool exit = false;

        Electronic laptop = new Electronic("Laptop", 50000, 24);
        Clothing tshirt = new Clothing("T-Shirt", 800, "L", "Cotton");

        laptop.ApplyDiscount(10);

        products.Add(laptop);
        products.Add(tshirt);

        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("1- Add a New Product");
            Console.WriteLine("2- Show Product Details");
            Console.WriteLine("0- Exit");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Choose An Option :");
            string input  = Console.ReadLine();
            int choice;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                Console.Write("Press any key to return to the menu");
                Console.ReadKey();
                continue;
            }
            try
                {
                switch (choice)
                {
                    case 1:
                        AddNewProduct(products);
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter Product Name : ");
                        string productName = Console.ReadLine();
                        string result = ShowDetails(products, productName);
                        Console.WriteLine(result);
                        Console.Write("Press any key to return to the menu");
                        Console.ReadKey();
                        break;
                    case 0:
                        exit = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Write("Press any key to return to the menu");
                Console.ReadKey();
            }
        }

    }
}
