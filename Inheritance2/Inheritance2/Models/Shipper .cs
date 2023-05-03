<<<<<<< HEAD
﻿using System;
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
    public void Update(int id, string name, string phone)
    {
        base.Id = id;
        base.Name = name;
        this.Phone = phone;
    }
    public List<Order> Orders { get; set; }
    public string Phone { get ; set; }
    }

=======
﻿using System;
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

>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
