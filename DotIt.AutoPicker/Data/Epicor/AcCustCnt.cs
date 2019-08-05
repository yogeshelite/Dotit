using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCustCnt
    {
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
