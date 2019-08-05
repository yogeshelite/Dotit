using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ComagneticMediaDef
    {
        public ComagneticMediaDef()
        {
            ComagneticMediaFormatHead = new HashSet<ComagneticMediaFormatHead>();
            ComagneticMediaReport = new HashSet<ComagneticMediaReport>();
        }

        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string Description { get; set; }
        public string SchemaId { get; set; }
        public string Coacode { get; set; }
        public string GenericOneTimeId { get; set; }
        public string ForeignOneTimeIdpattern { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ComagneticMediaFormatHead> ComagneticMediaFormatHead { get; set; }
        public virtual ICollection<ComagneticMediaReport> ComagneticMediaReport { get; set; }
    }
}
