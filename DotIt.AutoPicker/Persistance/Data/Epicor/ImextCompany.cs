using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImextCompany
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string TransferMethod { get; set; }
        public string CompanyCountryLangNameId { get; set; }
        public bool SendCustomer { get; set; }
        public bool SendProspect { get; set; }
        public bool SendSuspect { get; set; }
        public bool SendVend { get; set; }
        public bool SendPart { get; set; }
        public bool SendShip { get; set; }
        public bool SendArinv { get; set; }
        public bool RcvArinv { get; set; }
        public bool SendApinv { get; set; }
        public bool RcvApinv { get; set; }
        public bool AppurchType { get; set; }
        public bool SendAckToQue { get; set; }
        public bool Ictrading { get; set; }
        public int IcvendorNum { get; set; }
        public int IccustNum { get; set; }
        public string ExtCustId { get; set; }
        public string ExtVendorId { get; set; }
        public bool Apdiscount { get; set; }
        public string AuxPrgmType { get; set; }
        public string AuxPrgmName { get; set; }
        public bool SendPosugg { get; set; }
        public DateTime? LastConDate { get; set; }
        public int LastConTime { get; set; }
        public DateTime? LastFailedDate { get; set; }
        public int LastFailedTime { get; set; }
        public int TransferDays { get; set; }
        public int PonumBlockSize { get; set; }
        public int PonumBlockReorderPoint { get; set; }
        public int PonumBlockWarnPoint { get; set; }
        public string DefaultPlant { get; set; }
        public string CurrencyCode { get; set; }
        public bool SendGlaccounts { get; set; }
        public bool AllowGjalloc { get; set; }
        public bool AllowApalloc { get; set; }
        public string JrnGroupPrefix { get; set; }
        public bool AutoPostGj { get; set; }
        public string JournalCode { get; set; }
        public string CpayGroupPrefix { get; set; }
        public bool CpayAutoPost { get; set; }
        public string CpayLegalNum { get; set; }
        public bool AutoLoadCust { get; set; }
        public bool AutoLoadVend { get; set; }
        public bool AutoLoadPart { get; set; }
        public bool SendRev { get; set; }
        public bool SendPerCon { get; set; }
        public bool McsegOnly { get; set; }
        public bool SendConfigurator { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SendGlobalCoa { get; set; }
        public string SendGlobalCoatype { get; set; }
        public bool AlwaysUseGlinterComp { get; set; }
    }
}
