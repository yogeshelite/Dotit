using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacCustCnt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public int ConNum { get; set; }
        public bool Emergency { get; set; }
        public bool IsPrimary { get; set; }
        public bool Secondary { get; set; }
        public bool NextOfKin { get; set; }
        public bool PowerOfAttorney { get; set; }
        public bool EnduringPoa { get; set; }
        public bool MedicalAttorney { get; set; }
        public bool FinancialAttorney { get; set; }
        public bool JointSignatory { get; set; }
        public bool WillHolder { get; set; }
        public bool IsOther { get; set; }
        public string OtherValues { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
