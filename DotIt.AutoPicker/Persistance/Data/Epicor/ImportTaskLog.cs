using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImportTaskLog
    {
        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public long DocumentNumber { get; set; }
        public long ExecutionPlanId { get; set; }
        public long TaskId { get; set; }
        public long LogId { get; set; }
        public DateTime? EnteredOn { get; set; }
        public bool Error { get; set; }
        public string ErrorTableName { get; set; }
        public int ErrorRowNum { get; set; }
        public Guid ErrorSysRowId { get; set; }
        public string Message { get; set; }
        public string MessageType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ImportTask ImportTask { get; set; }
    }
}
