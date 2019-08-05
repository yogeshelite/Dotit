using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imcctag
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string Plant { get; set; }
        public int Ccyear { get; set; }
        public int Ccmonth { get; set; }
        public bool FullPhysical { get; set; }
        public int CycleSeq { get; set; }
        public string PartNum { get; set; }
        public string TagNum { get; set; }
        public string BinNum { get; set; }
        public string CountedBy { get; set; }
        public decimal CountedQty { get; set; }
        public string CountedTime { get; set; }
        public string TagNote { get; set; }
        public string EntryPerson { get; set; }
        public bool TagPrinted { get; set; }
        public bool TagReturned { get; set; }
        public DateTime? CountedDate { get; set; }
        public int TagStatus { get; set; }
        public bool BlankTag { get; set; }
        public string LotNum { get; set; }
        public string SerialNumber { get; set; }
        public string Uom { get; set; }
        public decimal FrozenQoh { get; set; }
        public decimal FrozenCost { get; set; }
        public DateTime? EntryDate { get; set; }
        public int EntryTime { get; set; }
        public decimal SheetNum { get; set; }
        public DateTime? FrozenTranDate { get; set; }
        public int FrozenTranTime { get; set; }
        public decimal ActivityBeforeCount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Pcidtag { get; set; }
        public string TopLevelPcid { get; set; }
        public string Pcid { get; set; }
        public string ItemPcid { get; set; }
        public bool ReturnNestedPcid { get; set; }
        public bool CctagBoolean01 { get; set; }
        public bool CctagBoolean02 { get; set; }
        public string CctagCharacter01 { get; set; }
        public string CctagCharacter02 { get; set; }
        public string CctagCharacter03 { get; set; }
        public string CctagCharacter04 { get; set; }
        public string CctagCharacter05 { get; set; }
        public DateTime? CctagDate01 { get; set; }
        public DateTime? CctagDate02 { get; set; }
        public decimal CctagDecimal01 { get; set; }
        public decimal CctagDecimal02 { get; set; }
        public int CctagInteger01 { get; set; }
        public int CctagInteger02 { get; set; }
    }
}
