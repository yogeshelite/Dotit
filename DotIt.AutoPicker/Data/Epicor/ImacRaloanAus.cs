﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacRaloanAus
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RaloanAusid { get; set; }
        public decimal Raid { get; set; }
        public decimal AgreedLoan { get; set; }
        public string LoanContractCd { get; set; }
        public DateTime? EffDt { get; set; }
        public DateTime? LoanDueDate { get; set; }
        public decimal LoanReceived { get; set; }
        public decimal LoanOutstanding { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public int CustNum { get; set; }
        public string GroupId { get; set; }
        public int HeadNum { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
