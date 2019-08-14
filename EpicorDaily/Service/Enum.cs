using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily.Service
{
    public enum PickerUserGroup
    {
         WHSE, WHSEMGR, WHSELEAD
    }

    enum PickerOrderStatus
    {
        Picked,
        Hold,
        Assigned,
        AssignPending
    }

    public enum Company
    {
        DIRF,
        NICCO,
        DOTIT
    }

}
