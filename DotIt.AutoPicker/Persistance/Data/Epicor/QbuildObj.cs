using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QbuildObj
    {
        public QbuildObj()
        {
            QbuildMapping = new HashSet<QbuildMapping>();
        }

        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public string ObjName { get; set; }
        public string ObjType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PcInputs PcInputs { get; set; }
        public virtual ICollection<QbuildMapping> QbuildMapping { get; set; }
    }
}
