using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuickEntry
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string QuickEntryType { get; set; }
        public string QuickEntryCode { get; set; }
        public string LaborType { get; set; }
        public string ProjectId { get; set; }
        public string PhaseId { get; set; }
        public string TimeTypCd { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public string RoleCode { get; set; }
        public string IndirectCode { get; set; }
        public bool IndirectExpense { get; set; }
        public int Pmuid { get; set; }
        public string MiscCode { get; set; }
        public bool Reimbursable { get; set; }
        public string TaxRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public bool TaxIncluded { get; set; }
        public string ExpenseCode { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public decimal LaborHrs { get; set; }
        public string ClaimCurrencyCode { get; set; }
        public string ExpenseCategory { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
