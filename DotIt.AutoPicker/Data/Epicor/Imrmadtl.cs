using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imrmadtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool OpenRma { get; set; }
        public bool OpenDtl { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string ReturnReasonCode { get; set; }
        public string Note { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string RevisionNum { get; set; }
        public decimal ReturnQty { get; set; }
        public string ReturnQtyUom { get; set; }
        public int RefInvoiceNum { get; set; }
        public int RefInvoiceLine { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public string ShipToNum { get; set; }
        public int ConNum { get; set; }
        public int CustNum { get; set; }
        public int OrderRelNum { get; set; }
        public int ShipToCustNum { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Ecccomment { get; set; }
        public string Eccrmanum { get; set; }
        public int Eccrmaline { get; set; }
    }
}
