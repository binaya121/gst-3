using System;

namespace GSTCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter product information
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter product quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter product cost: ");
            double productCost = double.Parse(Console.ReadLine());

            // Prompt the user to choose whether GST is included or not
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. GST is not included in the cost");
            Console.WriteLine("2. GST is already included in the cost");
            int option = int.Parse(Console.ReadLine());

            double totalCost = 0;

            // Calculate the total cost based on user's choice
            if (option == 1)
            {
                // Add GST to the cost
                totalCost = productCost + (productCost * 0.15);
            }
            else if (option == 2)
            {
                // Remove GST from the cost
                totalCost = (productCost * 3) / 23;
            }
            else
            {
                Console.WriteLine("Invalid option. Please select 1 or 2.");
                return; // Exit the program if an invalid option is chosen
            }

            // Calculate the total price for the given quantity
            double totalPrice = totalCost * quantity;

            // Display the results
            Console.WriteLine($"Product: {productName}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine("Original Cost: " + (option == 2 ? "$" + productCost.ToString("0.00") + " (including GST)" : "$" + productCost.ToString("0.00")));
            Console.WriteLine("Total Cost with GST: $" + totalCost.ToString("0.00"));
            Console.WriteLine($"Total Price for {quantity} items: ${totalPrice.ToString("0.00")}");

            // Wait for user input to exit
            Console.ReadLine();
        }
    }
}
