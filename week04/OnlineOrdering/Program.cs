// Author: Marcos Alas
// Project: Online Ordering Program
// Date of code: 04/04/2026
// A single file for all of my classes.

using System;
using System.Collections.Generic;

/* First class: Address */
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.Trim().ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}


/* Second class: Customer */
class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }
}


/* Third class: Product */
class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public string GetProductId() => _productId;
    public double GetPrice() => _price;
    public int GetQuantity() => _quantity;

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}


/* Fourth class: Order */
class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            Console.WriteLine("Shipping Cost: $5.00 (Local shipping fee in USA)");
            total += 5.00;
        }
        else
        {
            Console.WriteLine("Shipping Cost: $35.00 (International shipping fee)");
            total += 35.00;
        }

        return total;
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Products in Order:");
        foreach (Product p in _products)
        {
            Console.WriteLine($"Name: {p.GetName()}, ID: {p.GetProductId()}, Price: ${p.GetPrice()}, Quantity: {p.GetQuantity()}");
        }
        Console.WriteLine();
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" +
               _customer.GetName() + "\n" +
               _customer.GetAddress().GetFullAddress();
    }
}


/* Main class: Program */
class Program
{
    static void Main(string[] args)
    {
        // Example with the USA address
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Marcos Alas", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P01", 800, 1));
        order1.AddProduct(new Product("Mouse", "P02", 4, 2)); 

        // Example with the international address
        Address address2 = new Address("485 St Marcos St.", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Derick Sebastian", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P03", 750, 3));
        order2.AddProduct(new Product("Charger", "P04", 20, 3));

        Console.WriteLine("---- Order #1 ----"); 
        order1.DisplayProducts();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("---- Order #2 ----"); 
        order2.DisplayProducts();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}