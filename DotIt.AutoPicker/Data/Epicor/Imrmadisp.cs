using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imrmadisp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public int Rmareceipt { get; set; }
        public int Rmadisp { get; set; }
        public string DispType { get; set; }
        public string WareHouseCode { get; set; }
        public string BinNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string DispComment { get; set; }
        public string InspectorId { get; set; }
        public string InspectedBy { get; set; }
        public DateTime? InspectedDate { get; set; }
        public int InspectedTime { get; set; }
        public int NonConfTranId { get; set; }
        public string ReasonCode { get; set; }
        public decimal DispQty { get; set; }
        public string DispQtyUom { get; set; }
        public string SourceDbrecid { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool RequestMove { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool OverrideCosts { get; set; }
        public bool UseCurrentCost { get; set; }
        public string ToBinNum { get; set; }
        public string ToWareHouseCode { get; set; }
        public bool SetReassignSnasm { get; set; }
    }
}
