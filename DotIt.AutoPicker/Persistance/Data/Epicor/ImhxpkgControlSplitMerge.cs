using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImhxpkgControlSplitMerge
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public Guid PkgControlSplitMergeSysRowId { get; set; }
        public int Revision { get; set; }
        public string Company { get; set; }
        public int TranNum { get; set; }
        public string TranType { get; set; }
        public string Plant { get; set; }
        public string SourcePcid { get; set; }
        public string SourcePkgControlStatus { get; set; }
        public string SourceWarehouseCode { get; set; }
        public string SourceBinNum { get; set; }
        public string SourceLabelPrintControlStatus { get; set; }
        public string TargetPcid { get; set; }
        public string TargetPkgControlStatus { get; set; }
        public string TargetWarehouseCode { get; set; }
        public string TargetBinNum { get; set; }
        public string ItemPartNum { get; set; }
        public string ItemRevisionNum { get; set; }
        public string TargetLabelPrintControlStatus { get; set; }
        public string ItemLotNum { get; set; }
        public string ItemIum { get; set; }
        public decimal ItemQuantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
