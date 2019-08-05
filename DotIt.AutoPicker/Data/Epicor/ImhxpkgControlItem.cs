using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImhxpkgControlItem
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Pcid { get; set; }
        public long PciditemSeq { get; set; }
        public int Revision { get; set; }
        public string ItemPcid { get; set; }
        public string ItemPartNum { get; set; }
        public string ItemRevisionNum { get; set; }
        public string ItemPartDesc { get; set; }
        public string ItemLotNum { get; set; }
        public string ItemIum { get; set; }
        public decimal ItemQuantity { get; set; }
        public string Plant { get; set; }
        public string DemandType { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string TfordNum { get; set; }
        public int TfordLine { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public string CustPartNum { get; set; }
        public string CustPartRev { get; set; }
        public string CustPonum { get; set; }
        public string CustShipToEngineerAlert { get; set; }
        public bool SafetyIndicator { get; set; }
        public string PkgCodePartNum { get; set; }
        public string VendorPotype { get; set; }
        public int VendorPonum { get; set; }
        public int VendorPoline { get; set; }
        public int VendorPorelNum { get; set; }
        public string VendorPartNum { get; set; }
        public string VendorUom { get; set; }
        public decimal VendorQty { get; set; }
        public string ReceiptPackSlip { get; set; }
        public string ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ReceiptUom { get; set; }
        public decimal ReceiptQty { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public string PkgControlCharacter01 { get; set; }
        public string PkgControlCharacter02 { get; set; }
        public string PkgControlCharacter03 { get; set; }
        public string PkgControlCharacter04 { get; set; }
        public string PkgControlCharacter05 { get; set; }
        public DateTime? PkgControlDate01 { get; set; }
        public DateTime? PkgControlDate02 { get; set; }
        public bool PkgControlBoolean01 { get; set; }
        public bool PkgControlBoolean02 { get; set; }
        public decimal PkgControlDecimal01 { get; set; }
        public decimal PkgControlDecimal02 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ShipmentInvoicedPosted { get; set; }
        public string SupplyJobNum { get; set; }
    }
}
