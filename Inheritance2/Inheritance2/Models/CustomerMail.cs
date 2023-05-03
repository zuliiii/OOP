<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Inheritance2.Models.Base;

namespace Inheritance2.Models;

     class CustomerMail : CustomerBase
     {
    public CustomerMail() { }
    public CustomerMail(int id, string title, string mail)
    {
        base.Id = id;
        base.Title = title;
        this.Mail = mail;
    }

    public void Update(int id, string title, string mail)
    {
        base.Id = id;
        base.Title = title;
        this.Mail = mail;
    }

    public Customer Customer { get; set; }
      public string? Mail { get; set; }
     }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Inheritance2.Models.Base;

namespace Inheritance2.Models;

     class CustomerMail : CustomerBase
     {
    public CustomerMail() { }
    public CustomerMail(int id, string title, string mail)
    {
        base.Id = id;
        base.Title = title;
        this.Mail = mail;
    }

    public Customer Customer { get; set; }
      public string? Mail { get; set; }
     }

>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
