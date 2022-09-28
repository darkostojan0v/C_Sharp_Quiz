using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Enums;

namespace Task.Dtos
{
    public class OrderDto
    {
        public string Text { get; set; }
        public Priority Priority { get; set; }
    }
}
