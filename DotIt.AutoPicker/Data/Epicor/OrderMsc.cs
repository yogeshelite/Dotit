using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OrderMsc
    {
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public string FreqCode { get; set; }
        public string Quoting { get; set; }
        public bool Linked { get; set; }
        public int Icponum { get; set; }
        public int Icpoline { get; set; }
        public int IcposeqNum { get; set; }
        public string ExtCompany { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public decimal InMiscAmt { get; set; }
        public decimal DocInMiscAmt { get; set; }
        public decimal Rpt1InMiscAmt { get; set; }
        public decimal Rpt2InMiscAmt { get; set; }
        public decimal Rpt3InMiscAmt { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public bool ChangeTrackApproved { get; set; }
        public decimal ChangeTrackAmount { get; set; }
        public string ChangeTrackMemoDesc { get; set; }
        public string ChangeTrackMemoText { get; set; }
        public string ChangeTrackStatus { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
