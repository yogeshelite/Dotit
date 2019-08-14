using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Services
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


    public enum UserGroup
    {

        CONTROLLER, FINRO, IT, SALES, ECCSYNC, ENG, COMMVIEW, WHSE, CSR, KITTING, FINANCE, INV, WHSEMGR, ACCTMGR, MKTG, WHSELEAD, CSRMGR, BUYERS
    }
}
