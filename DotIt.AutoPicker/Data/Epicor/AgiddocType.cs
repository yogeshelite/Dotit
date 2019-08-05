using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AgiddocType
    {
        public string Company { get; set; }
        public string IddocTypeCode { get; set; }
        public string Afipcode { get; set; }
        public string Cotcode { get; set; }
        public bool Cuitmark { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
