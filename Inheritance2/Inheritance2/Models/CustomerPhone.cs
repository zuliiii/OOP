using System;
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

