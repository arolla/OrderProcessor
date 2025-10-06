package fr.arolla;

import java.util.List;

public class OrderProcessor {

    public void ProcessOrder(String customerId, List<String> items, String paymentType, String shippingType)
    {
        // Validation
        if (customerId == null || customerId.isEmpty()) throw new RuntimeException("Invalid customer");
        if (items == null || items.isEmpty()) throw new RuntimeException("No items");

        // Calculate total
        double total = 0;
        for (var item : items)
        {
            if (item.equals("BOOK")) total += 15.99;
            else if (item.equals("DVD")) total += 19.99;
            else if (item.equals("GAME")) total += 59.99;
            else throw new RuntimeException("Unknown item");
        }

        // Apply discount
        if (customerId.startsWith("VIP"))
        {
            total = total * 0.8; // 20% discount
        }
        else if (customerId.startsWith("GOLD"))
        {
            total = total * 0.9; // 10% discount
        }

        // Process payment
        if (paymentType.equals("CREDIT"))
        {
            System.out.println("Processing credit card payment: $" + total);
            // Credit card logic here
        }
        else if (paymentType.equals("PAYPAL"))
        {
            System.out.println("Processing PayPal payment: $" + total);
            // PayPal logic here
        }
        else if (paymentType.equals("BITCOIN"))
        {
            System.out.println("Processing Bitcoin payment: $" + total);
            // Bitcoin logic here
        }

        // Calculate shipping
        double shipping = 0;
        if (shippingType.equals("STANDARD"))
        {
            shipping = 5.99;
        }
        else if (shippingType.equals("EXPRESS"))
        {
            shipping = 15.99;
        }
        else if (shippingType.equals("OVERNIGHT"))
        {
            shipping = 29.99;
        }

        total += shipping;

        // Send notification
        if (customerId.contains("@"))
        {
            System.out.println("Sending email to: " + customerId);
        }
        else
        {
            System.out.println("Sending SMS to: " + customerId);
        }

        System.out.println("Order processed! Total: $" + total);
    }
}
