<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Inheritance2.Models.Base;


namespace Inheritance2.Models;

     class Customer : BaseEntity
     {
    public Customer() {}
    public Customer(int id, string firstName, string lastName)
     {
         base.Id = id;
         this.FirstName = firstName;
         this.LastName = lastName;
     }

    public void Update(int id, string firstName, string lastName)
    {
        base.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

      public List<CustomerAddres> CustomerAddres { get; set; }
      public List<CustomerMail> CustomerMail { get; set; }
      public List<CustomerPhone> CustomerPhone { get; set; }
      public List<Order>? Order { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
     }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Inheritance2.Models.Base;


namespace Inheritance2.Models;

     class Customer :BaseEntity
     {
    public Customer() {}
    public Customer(int id, string firstName, string lastName)
     {
         base.Id = id;
         this.FirstName = firstName;
         this.LastName = lastName;
     }

    public List<CustomerAddres> CustomerAddres { get; set; }
      public List<CustomerMail> CustomerMail { get; set; }
      public List<CustomerPhone> CustomerPhone { get; set; }
      public List<Order>? Order { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
     }

>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
