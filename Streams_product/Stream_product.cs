﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//González Hernández Pamela Citlali
//15211894

class Product
{
    public string Code;
    public string Description;
    public decimal Price;

    public Product(string c, string d, decimal p)
    {
        Code = c; Description = d; Price = p;
    }

    public override string ToString()
    {
        return String.Format("{0}-{1}-${2}", Code, Description, Price);
    }
}

class ProductDB
{
    const string dir = @"C:\Users\LabTec\Desktop\";
    const string path = dir + @"Products.txt";

    //public static List<Product> GetProducts()
    //{
        //StreamReader textIn = 
            //new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

        //List<Product> products = new List<Product>();
        //while (textIn.Peek() != -1)
        //{
            //string row = textIn.ReadLine();
            //string[] columns = row.Split('|');
            //products.Add(new Product(columns[0], columns[1], Convert.ToDecimal(columns[2])));
        //}
        //return products;
    //}

    public static List<Product> GetProductsBinary()
    {
        List<Product>products=new List<product>(C);

        BinaryReader binaryIn=new BinaryReader(new FileStream(path,FileMode.Open,FileAccess.Read));

        while(binaryIn.PeekChar() !=-1)
        {
            Product p=new Product();

            P.Code=binary.ReadString();
            P.Description=binaryIn.ReadString();
            P.Price=binaryDecimal();

            product.Add(p);
        }
        return products;
    }
    
    //public static void SaveProducts(List<Product> products)
    //{
        //StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

        //foreach (Product p in products)
        //{
            //textOut.Write(p.Code + "|");
            //textOut.Write(p.Description + "|");
            //textOut.WriteLine(p.Price);
        //}
        //textOut.Close();
    //}

    public static void SaveProductsBinary(List<Product> products)
    {
        BinaryWriter binaryOut=new BinaryWriter(
            new FileStream(path, FileMode.Create, FileAccess.Write));

        foreach(Product p in products)
        {
            binaryOut.Write(product.Code);
            binaryOut.Write(product.Description);
            binaryOut.Write(product.Price);
        }
    }

}
class Program
    {
        static void Main(string[] args)
        {
            List<Product> P = new List<Product>();
            P.Add(new Product("AAA", "XBOX ONE", 6000.23m));
            P.Add(new Product("AAA", "PS4", 5000.23m));
            P.Add(new Product("AAA", "Wii U", 3000.23m));
            ProductDB.SaveProducts(P);

            //List<Product> productos = new List<Product>();
            //productos= ProductDB.GetProducts();
            //foreach (Product p in productos)
                //Console.WriteLine(p);

            //Console.ReadKey();
        }
    }

