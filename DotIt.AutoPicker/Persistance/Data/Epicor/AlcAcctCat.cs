using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlcAcctCat
    {
        public string Company { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public string CategoryId { get; set; }
        public string BookId { get; set; }
        public string Coacode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
