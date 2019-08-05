using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRecDtl
    {
        public string Company { get; set; }
        public decimal RecDtlId { get; set; }
        public decimal RecHeadId { get; set; }
        public string SegCtcd { get; set; }
        public string ReferenceCode { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public bool DisplayLine { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int CustNum { get; set; }
        public string Bcd { get; set; }
        public int ClientCustNum { get; set; }
        public bool Adj { get; set; }
        public bool Cadj { get; set; }
        public bool Gadj { get; set; }
        public bool AdjCf { get; set; }
        public DateTime? AdjDate { get; set; }
        public decimal ExpQty { get; set; }
        public decimal ExpRate { get; set; }
        public decimal ActQty { get; set; }
        public decimal ActRate { get; set; }
        public string BadjRsnCd { get; set; }
        public string ReasonComment { get; set; }
        public bool Unrecover { get; set; }
        public decimal Cqty { get; set; }
        public decimal Crate { get; set; }
        public bool Editable { get; set; }
        public bool GetTran { get; set; }
        public string Ium { get; set; }
        public decimal SourceRecHeadId { get; set; }
        public decimal SourceRecDtlId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public decimal Raid { get; set; }
        public int ServicePlanId { get; set; }
    }
}
