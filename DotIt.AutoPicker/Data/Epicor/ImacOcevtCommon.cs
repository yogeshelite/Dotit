using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacOcevtCommon
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal OcevtCommonId { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string UniqueEventId { get; set; }
        public int SequenceNo { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string CareType { get; set; }
        public string OrgType { get; set; }
        public string SecondName { get; set; }
        public string PayrollTaxType { get; set; }
        public string PayrollTaxPortion { get; set; }
        public string ClaimMonth { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string CareRecipId { get; set; }
        public string Declaration { get; set; }
        public string DvafileNumber { get; set; }
        public string EntitlementType { get; set; }
        public string IndividualReferenceNumber { get; set; }
        public string MedicareNo { get; set; }
        public string ReasonForRequest { get; set; }
        public string Zip { get; set; }
        public string ExcessCareRecipient { get; set; }
        public string HoursOfService { get; set; }
        public string MinutesOfService { get; set; }
        public DateTime? DateOfEffect { get; set; }
        public string Suburb { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
