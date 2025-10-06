using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public class OrderProcessor
    {
        public void ProcessOrder(string customerId, List<string> items, string paymentType, string shippingType)
        {
            // Validation
            if (string.IsNullOrEmpty(customerId)) throw new Exception("Invalid customer");
            if (items == null || items.Count == 0) throw new Exception("No items");
            
            // Calculate total
            double total = 0;
            foreach (var item in items)
            {
                if (item == "BOOK") total += 15.99;
                else if (item == "DVD") total += 19.99;
                else if (item == "GAME") total += 59.99;
                else throw new Exception("Unknown item");
            }
            
            // Apply discount
            if (customerId.StartsWith("VIP"))
            {
                total = total * 0.8; // 20% discount
            }
            else if (customerId.StartsWith("GOLD"))
            {
                total = total * 0.9; // 10% discount
            }
            
            // Process payment
            if (paymentType == "CREDIT")
            {
                Console.WriteLine("Processing credit card payment: $" + total);
                // Credit card logic here
            }
            else if (paymentType == "PAYPAL")
            {
                Console.WriteLine("Processing PayPal payment: $" + total);
                // PayPal logic here
            }
            else if (paymentType == "BITCOIN")
            {
                Console.WriteLine("Processing Bitcoin payment: $" + total);
                // Bitcoin logic here
            }
            
            // Calculate shipping
            double shipping = 0;
            if (shippingType == "STANDARD")
            {
                shipping = 5.99;
            }
            else if (shippingType == "EXPRESS")
            {
                shipping = 15.99;
            }
            else if (shippingType == "OVERNIGHT")
            {
                shipping = 29.99;
            }
            
            total += shipping;
            
            // Send notification
            if (customerId.Contains("@"))
            {
                Console.WriteLine("Sending email to: " + customerId);
            }
            else
            {
                Console.WriteLine("Sending SMS to: " + customerId);
            }
            
            Console.WriteLine("Order processed! Total: $" + total);
        }
    }
}