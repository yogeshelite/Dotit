using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CnvProgsLog
    {
        public string SystemCode { get; set; }
        public string ConversionId { get; set; }
        public int EntryNum { get; set; }
        public string RunLevel { get; set; }
        public DateTime? EnteredOn { get; set; }
        public bool IsError { get; set; }
        public string MsgText { get; set; }
        public string MsgType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual CnvProgs CnvProgs { get; set; }
    }
}
