using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Agafipresponsibility
    {
        public string Company { get; set; }
        public string AfipresponsibilityCode { get; set; }
        public string Description { get; set; }
        public string Afipcode { get; set; }
        public string DocumentLetter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
