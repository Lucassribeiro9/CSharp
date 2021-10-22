using System;
using System.Collections.Generic;
using System.Text;

namespace NewEnum.Entities.Enums
{
    enum  OrderStatus : int // derivado do int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
