using System;
using System.Collections.Generic;

interface IPrintable
{
    void Print();
}

abstract class Invoice : IPrintable
{
    public List<(string product, double price)> Products = new List<(string, double)>();
    public double TaxRate { get; set; }
    public double Discount { get; set; }

    public abstract double CalculateTotal();

    public void Print()
    {
        Console.WriteLine("Invoice:");
        Console.WriteLine("Products:");
        foreach (var item in Products)
        {
            Console.WriteLine($" - {item.product}: {item.price:F2}");
        }
        Console.WriteLine($"Tax Rate: {TaxRate * 100}%");
        Console.WriteLine($"Discount: {Discount:F2}");
        Console.WriteLine($"Total Amount: ${CalculateTotal():F2}");
        Console.WriteLine(" ");
    }
}

class RetailInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var item in Products)
            subtotal += item.price;
        double totalWithTax = subtotal + subtotal * TaxRate;
        double totalAfterDiscount = totalWithTax - Discount;
        return totalAfterDiscount;
    }
}

class WholesaleInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var item in Products)
            subtotal += item.price;
       
        double discountAmount = subtotal * Discount;
        double totalWithTax = subtotal + subtotal * TaxRate - discountAmount;
        return totalWithTax;
    }
}

class Program
{
    static void Main()
    {
        RetailInvoice retail = new RetailInvoice();
        retail.TaxRate = 0.1;  
        retail.Discount = 5;  
        retail.Products.Add(("Tops", 20));
        retail.Products.Add(("Skirts", 40));
        retail.Print();

        WholesaleInvoice wholesale = new WholesaleInvoice();
        wholesale.TaxRate = 0.05;  
        wholesale.Discount = 0.1;  
        wholesale.Products.Add(("Bulk Shirt", 200));
        wholesale.Products.Add(("Bulk Pants", 400));
        wholesale.Print();
    }
}