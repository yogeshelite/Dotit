using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcashDeskOpr
    {
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
