using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ephistory
    {
        public string PackageId { get; set; }
        public int ActionNum { get; set; }
        public string UserId { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
