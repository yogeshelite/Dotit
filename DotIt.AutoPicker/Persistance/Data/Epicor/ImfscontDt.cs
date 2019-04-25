using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfscontDt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ContractNum { get; set; }
        public int ContractLine { get; set; }
        public string ContractCode { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal DocPricePerUnit { get; set; }
        public decimal ContractQty { get; set; }
        public string ProdCode { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public string InvoiceComment { get; set; }
        public int CustNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string ProjectId { get; set; }
        public string CommentText { get; set; }
        public string ContractType { get; set; }
        public string ContractComment { get; set; }
        public int SoldOrderNum { get; set; }
        public int SoldOrderLine { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal Rpt1PricePerUnit { get; set; }
        public decimal Rpt2PricePerUnit { get; set; }
        public decimal Rpt3PricePerUnit { get; set; }
        public bool Inactive { get; set; }
        public DateTime? DateInactivated { get; set; }
        public DateTime? BillStartDate { get; set; }
        public DateTime? BillEndDate { get; set; }
        public bool Invoiced { get; set; }
        public DateTime? DateInvoiced { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
