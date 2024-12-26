using System;
using codesampleprogram.Models;
using codesampleprogram.Services;

namespace codesampleprogram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize Response service
            var productService = new Response();

            // Example: Add a new product
            var newProduct = new Products
            {
                Serialno = 1,
                Name = "Sample Product",
                Price = 1000
            };

            productService.Addproducts(newProduct);
            Console.WriteLine("Product added successfully!");

            // Example: Delete a product by ID
            Console.WriteLine("Enter Product ID to delete:");
            ////int productId = Convert.ToInt32(Console.ReadLine());
            ////productService.DeleteProducts(productId);
            //Console.WriteLine("Product deleted successfully!");
        }
    }
}
