using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FsTech
    {
        public string Company { get; set; }
        public int CallNum { get; set; }
        public int SeqNum { get; set; }
        public string EmpId { get; set; }
        public string Name { get; set; }
        public bool OpenCall { get; set; }
        public string CnvEmpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
