using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Aglocation
    {
        public string Company { get; set; }
        public string LocationCode { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public string Cotcode { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
