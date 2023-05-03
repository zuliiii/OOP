<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

     class CustomerPhone : CustomerBase
     {
       public CustomerPhone() { }
    public CustomerPhone(int id, string title, int areaCode, string number)
    {
        base.Id = id;
        base.Title = title;
        this.AreaCode = areaCode;
        this.Number = number;
    }

    public void Update(int id, string title, int areaCode, string number)
    {
        base.Id = id;
        base.Title = title;
        this.AreaCode = areaCode;
        this.Number = number;
    }


    public Customer Customer { get; set; }
    public int? AreaCode { get; set; }
        public string? Number { get; set; }
     }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

     class CustomerPhone : CustomerBase
     {
       public CustomerPhone() { }
    public CustomerPhone(int id, string title, int areaCode, string number)
    {
        base.Id = id;
        base.Title = title;
        this.AreaCode = areaCode;
        this.Number = number;
    }


    public Customer Customer { get; set; }
    public int? AreaCode { get; set; }
        public string? Number { get; set; }
     }

>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
