<<<<<<< HEAD
﻿using System;
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

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

    public class Product : NameEntity
    {
    public Product() { }
    public Product(int id, string name, double price, double amount, bool unitsInStock)
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

>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
