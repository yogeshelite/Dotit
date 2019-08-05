using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imcompany
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string Fein { get; set; }
        public string StateTaxId { get; set; }
        public int CurrentFiscalYear { get; set; }
        public string Edicode { get; set; }
        public string TaxRegionCode { get; set; }
        public int CountryNum { get; set; }
        public int Number { get; set; }
        public string FrxDsn { get; set; }
        public string EschedFileSet { get; set; }
        public string ExternalId { get; set; }
        public string LogoFile { get; set; }
        public string EmpPhotoPath { get; set; }
        public string CalendarId { get; set; }
        public string AuxMailAddr { get; set; }
        public string FrxUserid { get; set; }
        public string FrxPassWord { get; set; }
        public string FiscalCalendarId { get; set; }
        public string LegalName { get; set; }
        public string TaxRegReason { get; set; }
        public string ActTypeCode { get; set; }
        public string OrgRegCode { get; set; }
        public string ManagerName { get; set; }
        public string ChiefAcctName { get; set; }
        public string ReportTypePref { get; set; }
        public string Wiapplication { get; set; }
        public bool WiautoCreateJob { get; set; }
        public bool WigetDetails { get; set; }
        public bool Wischedule { get; set; }
        public bool Wirelease { get; set; }
        public bool WishippingCosts { get; set; }
        public bool DeepCopy { get; set; }
        public bool DeepCopyDupOrRevEst { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string MapUrl { get; set; }
        public string Mxmunicipio { get; set; }
        public int Apboecheck { get; set; }
        public int CosequenceCert { get; set; }
        public bool SendToFsa { get; set; }
        public int EpicorAccountNum { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
