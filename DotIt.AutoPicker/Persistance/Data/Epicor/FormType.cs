using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FormType
    {
        public FormType()
        {
            Adjustment1099 = new HashSet<Adjustment1099>();
            Code1099 = new HashSet<Code1099>();
            Form1099 = new HashSet<Form1099>();
        }

        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ReturnCode { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<Adjustment1099> Adjustment1099 { get; set; }
        public virtual ICollection<Code1099> Code1099 { get; set; }
        public virtual ICollection<Form1099> Form1099 { get; set; }
    }
}
