<<<<<<< HEAD
﻿using System;
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


=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models.Base;

    public class NameEntity : BaseEntity
    {
        public string Name { get; set; }
    }


>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
