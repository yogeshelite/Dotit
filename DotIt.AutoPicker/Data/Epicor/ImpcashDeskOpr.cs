﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcashDeskOpr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool AllowDraftDoc { get; set; }
        public bool AllowUseExtnNum { get; set; }
        public string CashDeskId { get; set; }
        public string Company { get; set; }
        public bool OprTypeEnabled { get; set; }
        public string LegalNumberId { get; set; }
        public string OprTypeCode { get; set; }
        public string RoleCode { get; set; }
        public string TranDocTypeId { get; set; }
        public string ReportId { get; set; }
        public int ReportStyleNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
