﻿using OrderSignaIR.DataAccessLayer.Abstract;
using OrderSignaIR.DataAccessLayer.Concrete;
using OrderSignaIR.DataAccessLayer.Repositories;
using OrderSignaIR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(OrderSignaIRContext context) : base(context)
        {
        }
    }
}
