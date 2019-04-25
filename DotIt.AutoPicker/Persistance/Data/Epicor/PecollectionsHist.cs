using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PecollectionsHist
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public DateTime ChangeDate { get; set; }
        public bool Collections { get; set; }
        public DateTime? CollectionsDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
