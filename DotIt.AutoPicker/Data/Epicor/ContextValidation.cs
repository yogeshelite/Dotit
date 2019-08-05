using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ContextValidation
    {
        public string LikeId { get; set; }
        public string ContextTypeCode { get; set; }
        public string ValidationAdapter { get; set; }
        public string ValidationType { get; set; }
        public string RetrieverCombo { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual ContextMenu ContextMenu { get; set; }
    }
}
