﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.EntityLayer.Entities
{
    public class Order
    {
        public int OrderId{ get; set; }
        public string TableNumber { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
       
        public decimal TotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
