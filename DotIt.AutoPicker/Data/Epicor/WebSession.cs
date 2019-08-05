using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WebSession
    {
        public string SessId { get; set; }
        public string DcdUserId { get; set; }
        public int WebUserNum { get; set; }
        public string AppCode { get; set; }
        public string CurComp { get; set; }
        public string CurPlant { get; set; }
        public string SalesRepCode { get; set; }
        public int CustNum { get; set; }
        public int VendorNum { get; set; }
        public string ContactRowId { get; set; }
        public int CurOrderNum { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
