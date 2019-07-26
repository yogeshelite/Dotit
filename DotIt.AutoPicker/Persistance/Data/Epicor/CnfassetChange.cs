using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CnfassetChange
    {
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public string ChangedFieldName { get; set; }
        public int ChangeNum { get; set; }
        public string ChangedFieldValue { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangedBy { get; set; }
        public string Reason { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Fasset Fasset { get; set; }
    }
}
