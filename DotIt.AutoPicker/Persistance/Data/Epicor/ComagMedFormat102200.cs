using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ComagMedFormat102200
    {
        public string Company { get; set; }
        public string Coacode { get; set; }
        public string SchemaId { get; set; }
        public string SchemaFormat { get; set; }
        public string SegmentCode { get; set; }
        public string SegConcept { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
