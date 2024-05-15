﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.EntityLayer.Entities
{
	public class Notification
	{
        public int NotificationId { get; set; }
		public string Type { get; set; }
		public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
