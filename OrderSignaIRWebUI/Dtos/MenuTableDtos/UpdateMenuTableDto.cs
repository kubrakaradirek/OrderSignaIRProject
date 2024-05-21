using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIRWebUI.Dtos.MenuTableDtos
{
    public class UpdateMenuTableDto
    {
        public int MenuTableId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
