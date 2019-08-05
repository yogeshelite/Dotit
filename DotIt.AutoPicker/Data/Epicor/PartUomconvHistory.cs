using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartUomconvHistory
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public int Seq { get; set; }
        public DateTime LogDate { get; set; }
        public string OldUomclassId { get; set; }
        public string NewUomclassId { get; set; }
        public string OldPrimaryIum { get; set; }
        public string NewPrimaryIum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
