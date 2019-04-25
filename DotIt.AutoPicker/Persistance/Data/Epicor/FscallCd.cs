using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FscallCd
    {
        public string Company { get; set; }
        public string CallCode { get; set; }
        public string CallDescription { get; set; }
        public string CommentText { get; set; }
        public string TaxCatId { get; set; }
        public string IncomeTaxCode { get; set; }
        public bool GlobalFscallCd { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
