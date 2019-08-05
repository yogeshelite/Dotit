using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imprsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EmpUserChar1Label { get; set; }
        public string EmpUserChar2Label { get; set; }
        public string EmpUserChar3Label { get; set; }
        public string EmpUserChar4Label { get; set; }
        public string EmpUserDate1Label { get; set; }
        public string EmpUserDate2Label { get; set; }
        public string EmpUserDate3Label { get; set; }
        public string EmpUserDate4Label { get; set; }
        public string EmpUserDec1Label { get; set; }
        public string EmpUserDec2Label { get; set; }
        public string EmpUserInt1Label { get; set; }
        public string EmpUserInt2Label { get; set; }
        public string Password { get; set; }
        public string CheckSort { get; set; }
        public int SemiDay { get; set; }
        public DateTime? PrstartDate { get; set; }
        public string NoPrmgr { get; set; }
        public bool Hcmenabled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool PrintRates { get; set; }
    }
}
