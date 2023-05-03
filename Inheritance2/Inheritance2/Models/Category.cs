<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

 
public class Category : NameEntity
{

    public Category() { }

    public Category(int id, string name, string description) 
    { 
        base.Id = id;
        base.Name = name;
        this.Description = description;
    }
    public void Update(int id, string name, string description)
    {
        base.Id = id;
        base.Name = name;
        this.Description = description;
    }

    public string? Description { get; set; }

    public List<Product> Product { get; set; }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

 
public class Category : NameEntity
{

    public Category() { }

    public Category(int id, string name, string description) 
    { 
        base.Id = id;
        base.Name = name;
        this.Description = description;
    }

    public string? Description { get; set; }

    public List<Product> Product { get; set; }
}
>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
