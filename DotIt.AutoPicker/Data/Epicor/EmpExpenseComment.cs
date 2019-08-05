using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EmpExpenseComment
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public int EmpExpenseNum { get; set; }
        public int CommentNum { get; set; }
        public string CommentType { get; set; }
        public string CommentText { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateTime { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public int TaskSeqNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
