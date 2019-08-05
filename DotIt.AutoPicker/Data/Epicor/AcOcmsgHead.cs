using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcOcmsgHead
    {
        public string Company { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public string TransactionId { get; set; }
        public int RequestId { get; set; }
        public string MinorCustId { get; set; }
        public string ClaimType { get; set; }
        public string ServiceNum { get; set; }
        public string ClassCd { get; set; }
        public string AuthPfname { get; set; }
        public string AuthPlname { get; set; }
        public string CareRecipId { get; set; }
        public string CareRecipMname { get; set; }
        public string CareRecipFname { get; set; }
        public string CareRecipLname { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? EntryDate { get; set; }
        public int SegNum { get; set; }
        public bool Archived { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CastatusCd { get; set; }
        public string CastatusDesc { get; set; }
        public string MsgStatus { get; set; }
        public bool Signed { get; set; }
        public string SignedError { get; set; }
        public bool Submit { get; set; }
        public string SubmitError { get; set; }
        public string EvtStatus { get; set; }
        public string EventType { get; set; }
        public string MsgFile { get; set; }
        public bool ReadyToProcess { get; set; }
        public DateTime? EventDate { get; set; }
        public decimal Raid { get; set; }
        public decimal RadtlId { get; set; }
        public int CustNum { get; set; }
        public decimal RlvId { get; set; }
        public decimal RacfiheadId { get; set; }
        public decimal RoxyTrtId { get; set; }
        public decimal RentFdId { get; set; }
        public decimal RadtlExServId { get; set; }
        public decimal RadtlLiabId { get; set; }
        public string RspFile { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public bool Approval { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
