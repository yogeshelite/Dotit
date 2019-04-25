using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ConsType
    {
        public string Company { get; set; }
        public string ConsTypeId { get; set; }
        public string Description { get; set; }
        public string CalcType { get; set; }
        public string RateTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
