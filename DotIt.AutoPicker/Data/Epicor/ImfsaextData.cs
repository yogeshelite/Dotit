using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImfsaextData
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TableName { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string ContractCode { get; set; }
        public string CallCode { get; set; }
        public string WarrantyCode { get; set; }
        public int ContractNum { get; set; }
        public string EmpId { get; set; }
        public int FsaserviceOrderNum { get; set; }
        public int FsaserviceOrderResourceNum { get; set; }
        public string FsaequipmentPartNum { get; set; }
        public int FsaequipmentInstallId { get; set; }
        public string Fsaaction { get; set; }
        public int FsainstallationOrderNum { get; set; }
        public int FsainstallationOrderLine { get; set; }
        public bool FsainstallationRequired { get; set; }
        public decimal FsainstallationCost { get; set; }
        public string FsainstallationType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ManualDelete { get; set; }
        public bool FsarequiresServiceOrder { get; set; }
        public string FsadeliveryWarehouseCode { get; set; }
        public string FsadeliveryBinNum { get; set; }
        public int FsaserviceAgreementNum { get; set; }
    }
}
