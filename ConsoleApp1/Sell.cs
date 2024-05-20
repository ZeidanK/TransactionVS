using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    internal class Seller{  
        User user;
        Product[] productArray;
        

    public Seller(User user, Product[] productArray) {       
        this.user = user;
        this.SetProductArray(productArray);
    }
    bool SetProductArray(Product[] productArray){
        this.productArray=productArray;
        return true;
    }
    public Product[] GetProductArray(){
        return this.productArray;
    }
    public User GetUser() {
        return this.user;
    }
    
    public void AddProduct(Product newProduct) {
        Product[] newProductArray = new Product[productArray.Length + 1];
        for (int i = 0; i < productArray.Length; i++) {
            newProductArray[i].CopyFrom(productArray[i]);
        }
        newProductArray[newProductArray.Length - 1].CopyFrom(newProduct);
        productArray = newProductArray;
    }
    

    // Getters and Setters
    public User User {
        get { return user; }
        set { user = value; }
    }

    public Product[] ProductArray {
        get { return productArray; }
        set { productArray = value; }
    }
    public void DisplaySeller(){
        this.user.DisplayUser();
    }
    public void DisplayProducts(){
        if(productArray.Length==0)
            Console.WriteLine("No products to display");      
        foreach(Product product in productArray)
            Console.WriteLine("Product Name: "+product.GetName());
        


    }
      
    }
}    
