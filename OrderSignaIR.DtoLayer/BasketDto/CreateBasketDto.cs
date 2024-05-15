using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DtoLayer.BasketDto
{
    public class CreateBasketDto
    {
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }//Ürününidsine göre basket inecek
        public int MenuTableId { get; set; }
    }
}
