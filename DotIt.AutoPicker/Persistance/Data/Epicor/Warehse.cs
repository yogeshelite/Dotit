using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Warehse
    {
        public Warehse()
        {
            WhsePrinter = new HashSet<WhsePrinter>();
        }

        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Gldivision { get; set; }
        public int CountryNum { get; set; }
        public string Plant { get; set; }
        public int CcselectMethod { get; set; }
        public bool ExcludeInactive { get; set; }
        public bool ExcludeOnHold { get; set; }
        public bool ExcludeZeroQoh { get; set; }
        public bool ExcludeNegQoh { get; set; }
        public decimal LastSheetNum { get; set; }
        public decimal LastTagNum { get; set; }
        public string ManagerName { get; set; }
        public string DefRcvWhse { get; set; }
        public string DefRcvBin { get; set; }
        public string DefShipWhse { get; set; }
        public string DefShipBin { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string SalesRepCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool EnforcePkgControlRules { get; set; }
        public bool AllowBuildParent { get; set; }
        public bool IsHoldWarehouse { get; set; }
        public string WarehouseType { get; set; }
        public bool WarehouseTypeDefault { get; set; }
        public bool SendToFsa { get; set; }

        public virtual ICollection<WhsePrinter> WhsePrinter { get; set; }
    }
}
