using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysExtCompany
    {
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string TransferMethod { get; set; }
        public string ListDelimiter { get; set; }
        public string ExtCompanyName { get; set; }
        public string AppServerUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
