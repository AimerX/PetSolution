using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.Enums
{
    public enum OrderStatus
    {
        AwaitingExchange,
        Completed,
        Cancelled,
        InProgress,
        OnHold,
        PartiallyShipped

    }
}
