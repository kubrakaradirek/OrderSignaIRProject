using OrderSignaIR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.BusinessLayer.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
		void TChangeStatusToTrue(int id);
		void TChangeStatusToFalse(int id);
	}
}
