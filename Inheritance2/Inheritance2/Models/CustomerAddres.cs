using Inheritance2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models;
    public class CustomerAddres : CustomerBase
    {
    
    public string Country { get; set; }
    public string City { get; set; }
    public string? Town { get; set; }
    public string Street { get; set; }
    public string BuilngNo { get; set; }

}

