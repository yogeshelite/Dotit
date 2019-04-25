using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imfaaddition
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int AdditionNum { get; set; }
        public DateTime? Added { get; set; }
        public decimal AdditionCost { get; set; }
        public string Description { get; set; }
        public int VendorNum { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNum { get; set; }
        public int Ponum { get; set; }
        public string JobNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string Location { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Serialno { get; set; }
        public bool NewAsset { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostDate { get; set; }
        public string PostedBy { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public bool ReadyToPost { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public decimal GrantAmt { get; set; }
        public string AdditionType { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public int InvoiceLine { get; set; }
        public string PartNum { get; set; }
        public decimal TransferQty { get; set; }
        public string TransferUom { get; set; }
        public string LotNum { get; set; }
        public decimal DocAdditionCost { get; set; }
        public decimal DocGrantAmt { get; set; }
        public decimal Rpt1AdditionCost { get; set; }
        public decimal Rpt1GrantAmt { get; set; }
        public decimal Rpt2AdditionCost { get; set; }
        public decimal Rpt2GrantAmt { get; set; }
        public decimal Rpt3AdditionCost { get; set; }
        public decimal Rpt3GrantAmt { get; set; }
        public bool InterGroup { get; set; }
        public string LocId { get; set; }
        public string EquipId { get; set; }
        public string Brand { get; set; }
        public decimal TransferUnits { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool HdrCostRecorded { get; set; }
        public string RecordedRegList { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public bool CoisOneTime { get; set; }
        public string CooneTimeId { get; set; }
    }
}
