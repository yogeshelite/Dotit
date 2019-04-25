using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ElementParameter
    {
        public string ElementHeaderId { get; set; }
        public int ParameterId { get; set; }
        public string ParameterName { get; set; }
        public int ParameterOrder { get; set; }
        public string ParameterDataType { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ElementHeader ElementHeader { get; set; }
    }
}
