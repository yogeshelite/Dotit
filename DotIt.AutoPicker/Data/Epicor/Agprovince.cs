using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Agprovince
    {
        public string Company { get; set; }
        public string ProvinceCode { get; set; }
        public string Afipcode { get; set; }
        public string Cotcode { get; set; }
        public string Jurisdiction { get; set; }
        public bool UseCensus { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
