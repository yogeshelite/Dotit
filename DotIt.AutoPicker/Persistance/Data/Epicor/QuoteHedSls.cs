using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QuoteHedSls
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public string Priority { get; set; }
        public string UserStatus { get; set; }
        public bool ClientAware { get; set; }
        public DateTime? EnquiryDate { get; set; }
        public string ContactMethod { get; set; }
        public string ReferralSource { get; set; }
        public string ReferredBy { get; set; }
        public string CareType { get; set; }
        public string SlsshortChar01 { get; set; }
        public string SlsshortChar02 { get; set; }
        public string SlsshortChar03 { get; set; }
        public string SlsshortChar04 { get; set; }
        public string SlsshortChar05 { get; set; }
        public decimal Slsnumber01 { get; set; }
        public decimal Slsnumber02 { get; set; }
        public decimal Slsnumber03 { get; set; }
        public decimal Slsnumber04 { get; set; }
        public decimal Slsnumber05 { get; set; }
        public DateTime? Slsdate01 { get; set; }
        public DateTime? Slsdate02 { get; set; }
        public DateTime? Slsdate03 { get; set; }
        public DateTime? Slsdate04 { get; set; }
        public DateTime? Slsdate05 { get; set; }
        public bool SlscheckBox01 { get; set; }
        public bool SlscheckBox02 { get; set; }
        public bool SlscheckBox03 { get; set; }
        public bool SlscheckBox04 { get; set; }
        public bool SlscheckBox05 { get; set; }
        public string Slscharacter01 { get; set; }
        public string Slscharacter02 { get; set; }
        public string Slscharacter03 { get; set; }
        public string Slscharacter04 { get; set; }
        public string Slscharacter05 { get; set; }
        public bool CarerAware { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
