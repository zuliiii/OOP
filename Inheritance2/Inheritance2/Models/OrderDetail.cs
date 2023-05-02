using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance2.Models.Base;


namespace Inheritance2.Models;

    public class OrderDetail : BaseEntity
    {

    public OrderDetail() { }

    public OrderDetail(int id, int orderId, int productId, double price, int count, int discount)
    {
        base.Id = id;
        this.OrderId = orderId;
        this.ProductId = productId;
        this.Price = price;
        this.Count = count;
        this.Discount = discount;
    }


    public int OrderId { get; set; }
      public int ProductId { get; set; }
      public double Price { get; set; }
      public int Count { get; set; }
      public int? Discount { get; set; }
      public Order Order { get; set; }
}

