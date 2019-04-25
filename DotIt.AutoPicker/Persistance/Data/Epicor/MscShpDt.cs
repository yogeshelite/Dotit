using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MscShpDt
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public string LineType { get; set; }
        public int Packages { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public string RevisionNum { get; set; }
        public string ShipComment { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public int ShpConNum { get; set; }
        public string Wum { get; set; }
        public string LotNum { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Plant { get; set; }
        public decimal Quantity { get; set; }
        public int CallNum { get; set; }
        public int CallLine { get; set; }
        public int MtlSeq { get; set; }
        public int AssemblySeq { get; set; }
        public string JobNum { get; set; }
        public int Dmrnum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int Rmareceipt { get; set; }
        public int Rmadisp { get; set; }
    }
}
