﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DtoLayer.CategoryDto
{
    public class UpdateCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
