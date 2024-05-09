﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DataAccessLayer.Abstract
{
    public interface IGenericDal< T> where T : class
    {
        void Add(T entity);    
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetListAll();

    }
}
