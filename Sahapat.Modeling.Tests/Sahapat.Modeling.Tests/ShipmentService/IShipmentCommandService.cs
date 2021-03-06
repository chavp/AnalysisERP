﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.ShipmentService
{
    public interface IShipmentCommandService
    {
        ReceivedPackagingContentResult ReceivedPackagingContent(Guid packagingContentId, Guid productId, double quantityRejected);
    }
}
