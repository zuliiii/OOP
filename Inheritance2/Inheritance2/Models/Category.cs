using System;
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
