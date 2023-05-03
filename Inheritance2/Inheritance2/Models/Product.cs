using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

    public class Product : NameEntity
    {
    public Product(int id) : base(id) { }
    public Product(int id, string name, double price, double amount, bool unitsInStock) : this(id)
    {
        base.Id = id;
        base.Name = name;
        this.Price = price;
        this.Amount = amount;
        this.UnitsInStock = unitsInStock;
    }
    public void Update(int id, string name, double price, double amount, bool unitsInStock)
    {
        base.Id = id;
        base.Name = name;
        this.Price = price;
        this.Amount = amount;
        this.UnitsInStock = unitsInStock;
    }



    public double Price { get; set; }
        public double Amount { get; set; }
        public bool UnitsInStock { get; set; }
    }

