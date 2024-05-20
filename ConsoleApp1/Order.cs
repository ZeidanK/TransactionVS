using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1//the name of the project that contains the namespace information must be the same as the project name
{
    internal class Order{  
        User buyer;
        Product[] products;
        double totalPrice;
        int numberOfProducts;

    public Order(User buyer, Product[] products, double totalPrice, int numberOfProducts):this() {
        this.SetBuyer(buyer);
        this.SetProducts(products);
        this.SetTotalPrice(totalPrice);
        this.SetNumberOfProducts(numberOfProducts);
    }
    public Order(Order order):this() {
        this.SetBuyer(order.GetBuyer());
        this.SetProducts(order.GetProducts());
        this.SetTotalPrice(order.GetTotalPrice());
        this.SetNumberOfProducts(order.GetNumberOfProducts());
    }
    public Order() {
        this.buyer = new User();
        this.products = new Product[0];
        this.totalPrice = 0;
        this.numberOfProducts = 0;
    }
    public User GetBuyer() {
        return this.buyer;
    }
    public bool SetBuyer(User buyer) {
        this.buyer = buyer;
        return true;
    }


    public Product[] GetProducts() {
        return this.products;
    }
    public bool SetProducts(Product[] products) {
        this.products = products;
        return true;
    }
    public double GetTotalPrice() {
        return this.totalPrice;
    }
    public void SetTotalPrice(double totalPrice) {
        this.totalPrice = totalPrice;
    }
    public int GetNumberOfProducts() {
        return this.numberOfProducts;
    }
    public void SetNumberOfProducts(int numberOfProducts) {
        this.numberOfProducts = numberOfProducts;
    }
    public void DisplayOrder(){
        System.Console.WriteLine("Order Information: ");
        System.Console.WriteLine("Total Price: "+this.totalPrice);
        System.Console.WriteLine("Number of Products: "+this.numberOfProducts);        
        this.buyer.DisplayUser();
        foreach(Product product in products){
            product.DisplayProduct();
        }
    }


    public void AddProduct(Product newProduct) {
        Product[] newProductArray = new Product[products.Length + 1];
        for (int i = 0; i < products.Length; i++) {
            newProductArray[i].CopyFrom(products[i]);
        }
        newProductArray[newProductArray.Length - 1].CopyFrom(newProduct);
        products = newProductArray;
    }


}    
}