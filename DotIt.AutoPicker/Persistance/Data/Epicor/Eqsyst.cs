using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Eqsyst
    {
        public string Company { get; set; }
        public int StartQuoteNum { get; set; }
        public int FollowUpDays { get; set; }
        public int ExpirationDays { get; set; }
        public int QuoteDueDays { get; set; }
        public string CheckOff1Label { get; set; }
        public string CheckOff2Label { get; set; }
        public string CheckOff3Label { get; set; }
        public string CheckOff4Label { get; set; }
        public string CheckOff5Label { get; set; }
        public string MarkUpId { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public bool PreventQqchange { get; set; }
        public bool LogChanges { get; set; }
        public bool GenQuoteQtys { get; set; }
        public bool QuoReadyToCalcDflt { get; set; }
        public bool ReduceRelQty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool RefreshWorksheetOd { get; set; }
        public bool GetCostsFromInventory { get; set; }
        public string DfltExpectedQtyTo { get; set; }
        public bool DfltOrderQtyToExpQty { get; set; }
        public decimal SellingExpectedQty { get; set; }
    }
}
