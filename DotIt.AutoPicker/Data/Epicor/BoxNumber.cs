using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BoxNumber
    {
        public BoxNumber()
        {
            Code1099 = new HashSet<Code1099>();
            Form1099Dtl = new HashSet<Form1099Dtl>();
        }

        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public string BoxNum { get; set; }
        public string Description { get; set; }
        public string ElectronicCode { get; set; }
        public string Comment { get; set; }
        public bool Inactive { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string AggregateBoxNum { get; set; }

        public virtual ICollection<Code1099> Code1099 { get; set; }
        public virtual ICollection<Form1099Dtl> Form1099Dtl { get; set; }
    }
}
