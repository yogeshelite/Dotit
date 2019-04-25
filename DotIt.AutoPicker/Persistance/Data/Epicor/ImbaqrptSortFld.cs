using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImbaqrptSortFld
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BaqrptId { get; set; }
        public string SortId { get; set; }
        public bool SystemFlag { get; set; }
        public string DataTableId { get; set; }
        public int Seq { get; set; }
        public string FieldName { get; set; }
        public bool IsAscending { get; set; }
        public string DisplayName { get; set; }
        public int DispOrder { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
