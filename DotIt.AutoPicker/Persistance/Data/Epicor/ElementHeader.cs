using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ElementHeader
    {
        public ElementHeader()
        {
            ElementDetail = new HashSet<ElementDetail>();
            ElementDisplayColumn = new HashSet<ElementDisplayColumn>();
            ElementParameter = new HashSet<ElementParameter>();
            SolutionTypeDetail = new HashSet<SolutionTypeDetail>();
        }

        public string ElementHeaderId { get; set; }
        public string ElementDesc { get; set; }
        public string ParentTableName { get; set; }
        public string BusinessObject { get; set; }
        public string Bomethod { get; set; }
        public bool IsDelivered { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ElementDetail> ElementDetail { get; set; }
        public virtual ICollection<ElementDisplayColumn> ElementDisplayColumn { get; set; }
        public virtual ICollection<ElementParameter> ElementParameter { get; set; }
        public virtual ICollection<SolutionTypeDetail> SolutionTypeDetail { get; set; }
    }
}
