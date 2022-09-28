using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Enums;
using Task.Domain.Models;

namespace Task.Dtos
{
    public class AddOrderDto
    {
        public string Text { get; set; }
        public Priority Priority { get; set; }

    }
}
