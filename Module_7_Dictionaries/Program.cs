using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Module_7_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory myInventory = new Inventory();



            Product myProduct = new Product();

            myInventory.AddProductToTheInventory(myProduct, "ABC123");
            myInventory.AddProductToTheInventory(myProduct, "ABC456");
            myInventory.AddProductToTheInventory(myProduct, "ABC789");
            myInventory.AddProductToTheInventory(myProduct, "DEF123");
            myInventory.AddProductToTheInventory(myProduct, "DEF456");
            myInventory.AddProductToTheInventory(myProduct, "DEF789");
            myInventory.AddProductToTheInventory(myProduct, "GHI123");
            myInventory.AddProductToTheInventory(myProduct, "GHI456");
            myInventory.AddProductToTheInventory(myProduct, "GHI789");
            myInventory.AddProductToTheInventory(myProduct, "CAR123");
            myInventory.AddProductToTheInventory(myProduct, "CLO456");
            myInventory.AddProductToTheInventory(myProduct, "PET789");
            myInventory.AddProductToTheInventory(myProduct, "FOO123");
            myInventory.AddProductToTheInventory(myProduct, "FRO456");
            myInventory.AddProductToTheInventory(myProduct, "SHO789");
            myInventory.AddProductToTheInventory(myProduct, "ELE123");
            myInventory.AddProductToTheInventory(myProduct, "TOY456");
            myInventory.AddProductToTheInventory(myProduct, "SPR789");
            myInventory.AddProductToTheInventory(myProduct, "APP123");
            myInventory.AddProductToTheInventory(myProduct, "CRA456");

            myInventory.HowManySectionsDoWeHave();




        }
    }

}

public class Inventory
{
    Dictionary<string, Product> myInventory = new Dictionary<string, Product>();


    public void AddProductToTheInventory(Product newProduct, string key)
    {
        int count = myInventory.Count;

        bool doesItExist = myInventory.ContainsKey(key);

        if (!doesItExist)
        {
            myInventory.Add(key, newProduct);
        }
        else
        {
            Console.WriteLine("Key already exists");
        }


    }

    public void HowManySectionsDoWeHave()
    {
        Console.WriteLine("We have " + myInventory.Count + " sections in use.");
    }
}


public class Product
{
    public string Name { get; set; }
    public string Phone { get; set; }
}