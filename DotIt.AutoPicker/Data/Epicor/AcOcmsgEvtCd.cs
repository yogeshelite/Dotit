using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcOcmsgEvtCd
    {
        public string Company { get; set; }
        public decimal OcmsgEvtCdid { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public string MsgType { get; set; }
        public string MsgCd { get; set; }
        public string MsgText { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
