using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PeinvcCollectionsHist
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool InCollections { get; set; }
        public DateTime? CollectionsDate { get; set; }
        public bool Posted { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
