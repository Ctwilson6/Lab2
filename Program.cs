using System;

class SherlenithasShop
{
    static void Main()
    {
        const double COST_OF_SANDWICH = 4.75;
        const double COST_OF_TOPPING = 0.55;
        const double DISCOUNT_AMOUNT = 0.10;

        // Input for number of sandwiches
        Console.Write("Enter the number of sandwiches: ");
        string? sandwichInput = Console.ReadLine();
        if (!int.TryParse(sandwichInput, out int numberOfSandwiches))
        {
            Console.WriteLine("Invalid input for number of sandwiches. Please enter a valid number.");
            return;
        }

        // Input for number of toppings
        Console.Write("Enter the number of toppings: ");
        string? toppingsInput = Console.ReadLine();
        if (!int.TryParse(toppingsInput, out int numberOfToppings))
        {
            Console.WriteLine("Invalid input for number of toppings. Please enter a valid number.");
            return;
        }

        // Input for tip amount
        Console.Write("Enter the tip amount (as a decimal): ");
        string? tipInput = Console.ReadLine();
        if (!double.TryParse(tipInput, out double tip))
        {
            Console.WriteLine("Invalid input for the tip amount. Please enter a valid number.");
            return;
        }

        // Calculate costs
        double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
        double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
        double baseCost = totalSandwichCost + totalToppingCost;

        double discountedCost = baseCost * (1 - DISCOUNT_AMOUNT);
        double orderCost = discountedCost + tip;

        // Output the total cost
        Console.WriteLine($"The total order cost is: {orderCost:F2}");
    }
}
