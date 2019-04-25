using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Person
    {
        public string Company { get; set; }
        public string PersonId { get; set; }
        public string Name { get; set; }
        public bool InActive { get; set; }
        public string AlertGroupList { get; set; }
        public string EmailAddress { get; set; }
        public string CnvEmpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
