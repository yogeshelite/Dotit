using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Mmsyst
    {
        public string Company { get; set; }
        public string DefaultStatusId { get; set; }
        public string TemplateJobNum { get; set; }
        public string JobPrefix { get; set; }
        public int MaintBuffer { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
