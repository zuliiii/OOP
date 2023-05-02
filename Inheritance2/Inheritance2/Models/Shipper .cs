using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

    public class Shipper : NameEntity
    {
    public Shipper() { }
    public Shipper(int id, string name, string phone)
    {
        base.Id = id;
        base.Name = name;
        this.Phone = phone;
    }
    public string Phone { get ; set; }
    }

