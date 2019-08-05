using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxReport
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Description { get; set; }
        public DateTime? FromTranDate { get; set; }
        public DateTime? ToTranDate { get; set; }
        public string ReportTitle { get; set; }
        public bool Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public string RptChecksum { get; set; }
        public bool IncludeAp { get; set; }
        public bool IncludeAr { get; set; }
        public int SortBy { get; set; }
        public string TaxTypeList { get; set; }
        public string TaxLiabilityList { get; set; }
        public string TaxJurisList { get; set; }
        public string ReportCategoryList { get; set; }
        public string CustomerList { get; set; }
        public string SupplierList { get; set; }
        public decimal MxbalanceToCredit { get; set; }
        public decimal MxonChargeToCredit { get; set; }
        public decimal MxonCountToCredit { get; set; }
        public decimal Mxcompesation { get; set; }
        public decimal Mxreimbursement { get; set; }
        public decimal Mxwhselected { get; set; }
        public decimal MxtotalOnCharge { get; set; }
        public decimal MxtotalOnCount { get; set; }
        public decimal MxwithholdingVat { get; set; }
        public decimal MxsurplusAmount { get; set; }
        public bool MxfiltersReady { get; set; }
        public bool MxallProportion { get; set; }
        public string MxreceiveMethod { get; set; }
        public string MxpropType { get; set; }
        public decimal MxchargeAmount { get; set; }
        public decimal MxonCountAmount { get; set; }
        public string FiscalCalendarId { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public bool Mxproportion { get; set; }
        public int MxcurrMonth { get; set; }
        public string RevReportCategoryList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DateBasis { get; set; }
        public bool BeaskPayment { get; set; }
        public bool Berestitution { get; set; }
        public bool BeclientListing { get; set; }
        public string BedeclComment { get; set; }
        public string BedeclLanguage { get; set; }
        public int EftheadUid { get; set; }
        public string OutputFile { get; set; }
        public int BackDatedItems { get; set; }
    }
}
