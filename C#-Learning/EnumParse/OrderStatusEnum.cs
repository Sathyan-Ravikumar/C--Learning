using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.EnumParse
{
    public enum OrderStatusEnum
    {
        Pending,
        Processing,
        Shipped = 5,
        Delivered,
        Cancelled
    }
}
