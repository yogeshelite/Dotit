using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Fadisposal
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int DisposalNum { get; set; }
        public DateTime? Disposed { get; set; }
        public decimal DisposalCost { get; set; }
        public string Description { get; set; }
        public int InvoiceNum { get; set; }
        public int CustNum { get; set; }
        public int InvoiceLine { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Serialno { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostDate { get; set; }
        public string PostedBy { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string CustName { get; set; }
        public int OrderNum { get; set; }
        public string JobNum { get; set; }
        public bool ReadyToPost { get; set; }
        public decimal Proceed { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string DisposalType { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public string PartNum { get; set; }
        public decimal TransferQty { get; set; }
        public string TransferUom { get; set; }
        public string LotNum { get; set; }
        public string PartDescription { get; set; }
        public decimal DocDisposalCost { get; set; }
        public decimal Rpt1DisposalCost { get; set; }
        public decimal Rpt2DisposalCost { get; set; }
        public decimal Rpt3DisposalCost { get; set; }
        public decimal DocProceed { get; set; }
        public decimal Rpt1Proceed { get; set; }
        public decimal Rpt2Proceed { get; set; }
        public decimal Rpt3Proceed { get; set; }
        public string LocId { get; set; }
        public string EquipId { get; set; }
        public string Brand { get; set; }
        public decimal TransferUnits { get; set; }
        public decimal DocProceedInvBal { get; set; }
        public decimal AssetBalOurQty { get; set; }
        public string AssetQtyIum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool HdrCostRecorded { get; set; }
        public string RecordedRegList { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
