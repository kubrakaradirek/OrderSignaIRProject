﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DtoLayer.SocialMediaDto
{
    public class GetSocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
