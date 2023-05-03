<<<<<<< HEAD
﻿using Inheritance2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance2.Models;

    public enum ShipStatus 
    {
      none,
      sifaris_alindi=1,
      sifaris_hazirlandi =2,
      sifaris_kargoya_verildi =3,
      sifarisin_teslimat_noktasinda =4,

    }

=======
﻿using Inheritance2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models;
    public class ShipStatus 
    {
    public int Id { get; set; }
    public string Name { get; set; }
    }

>>>>>>> c1d4489babd11369eafef25153d7b9e526e8d15d
