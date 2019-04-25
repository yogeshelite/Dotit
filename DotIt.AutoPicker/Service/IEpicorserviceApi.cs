using DotIt.AutoPicker.Persistance.Data.Epicor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Models
{
    public interface IEpicorserviceApi
    {
        IList<PickedOrders> GetPickedOrderList();
        IList<OrderDtl> GetPendingPickOrderList();

        IList<OrderHed> GetOrderHead();
    }
}
