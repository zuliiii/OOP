using Inheritance2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models;
    public class CustomerAddres : CustomerBase
    {
    public CustomerAddres(string country, string city, string? town, string street, string builngNo)
    {
        Country = country;
        City = city;
        Town = town;
        Street = street;
        BuilngNo = builngNo;
    }
    public void Update(string country, string city, string? town, string street, string builngNo)
    {
        Country = country;
        City = city;
        Town = town;
        Street = street;
        BuilngNo = builngNo;
    }

    public string Country { get; set; }
      public string City { get; set; }
      public string? Town { get; set; }
      public string Street { get; set; }
      public string BuilngNo { get; set; }

}

