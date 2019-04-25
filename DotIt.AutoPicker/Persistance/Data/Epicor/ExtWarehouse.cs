using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtWarehouse
    {
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string TransferMethod { get; set; }
        public string ExtCompanyId { get; set; }
        public string ExtPlantId { get; set; }
        public string ExtWarehouseId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
