using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Services
{
    public enum LineItemStatus
    {

        Picked = 0,
        UnPicked = 1,
        Quarentine = 2,
        Replenish = 3,
        InventoryControl = 4,
        Hold = 5, Pending = 6
    };
    public enum PickerUserGroup
    {
        WHSE, WHSEMGR, WHSELEAD
    }

    enum OrderStatus
    {
    
        Hold,
        Complete,
        Assigned,
        Pending
    }


    public enum UserGroup
    {

        CONTROLLER, FINRO, IT, SALES, ECCSYNC, ENG, COMMVIEW, WHSE, CSR, KITTING, FINANCE, INV, WHSEMGR, ACCTMGR, MKTG, WHSELEAD, CSRMGR, BUYERS
    }
}
