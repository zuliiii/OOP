using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;

namespace Inheritance2.Models;

    public class Order : BaseEntity
    {

    public Order() { }
    public Order(int id, int customerId, DateTime orderDate, DateTime deliveredDate, int shipperId, int customerAdderessId, int status)
    {
        base.Id = id;
        this.CustomerId = customerId;
        this.OrderDate = orderDate;
        this.DeliveredDate = deliveredDate;
        this.ShipperId = shipperId;
        this.CustomerAdderessId = customerAdderessId;
        this.Status = status;
    }


    public int CustomerId { get; set; }
     public DateTime OrderDate { get; set; }
     public DateTime DeliveredDate { get; set; }
     public int ShipperId { get; set; }
    public int CustomerAdderessId { get; set; }
    public int Status { get; set; }

    public List<OrderDetail> OrderDetails { get; set; }



}

