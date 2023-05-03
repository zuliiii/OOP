using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models.Base;

    public class NameEntity : BaseEntity
    {
    public NameEntity() { }
    public NameEntity(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    }


