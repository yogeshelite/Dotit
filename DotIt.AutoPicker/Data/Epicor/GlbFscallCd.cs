using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbFscallCd
    {
        public string CallCode { get; set; }
        public string CallDescription { get; set; }
        public string CommentText { get; set; }
        public string Company { get; set; }
        public string IncomeTaxCode { get; set; }
        public string TaxCatId { get; set; }
        public string GlbCompany { get; set; }
        public string GlbCallCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFscallCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
