using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    // Constructor
    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Getters
    public string GetName() => name;
    public int GetProductId() => productId;
    public decimal GetPrice() => price;
    public int GetQuantity() => quantity;

    // Method to calculate total cost of the product
    public decimal CalculateTotalCost() => price * quantity;
}

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Getters
    public string GetStreet() => street;
    public string GetCity() => city;
    public string GetState() => state;
    public string GetCountry() => country;

    // Method to return if address is in the USA
    public bool IsInUSA() => country.ToLower() == "usa";

    // Method to return full address as a string
    public string GetFullAddress() => $"{street}\n{city}, {state}\n{country}";
}

class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getters
    public string GetName() => name;
    public Address GetAddress() => address;

    // Method to check if customer is in the USA
    public bool IsInUSA() => address.IsInUSA();
}

class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    // Method to calculate the total price of the order
    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }
        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create sample products
        Product product1 = new Product("Laptop", 101, 1000m, 2);
        Product product2 = new Product("Mouse", 102, 25m, 1);
        Product product3 = new Product("Keyboard", 103, 50m, 1);

        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Vancouver", "BC", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        List<Product> products1 = new List<Product> { product1, product2 };
        List<Product> products2 = new List<Product> { product3 };
        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        // Display packing label, shipping label, and total price for both orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
