﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DtoLayer.TestimonialDto
{
    public class ResultTestimonialDto
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
