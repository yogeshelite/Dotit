using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LangTran
    {
        public string LangNameId { get; set; }
        public int OrgTextId { get; set; }
        public string ProgramId { get; set; }
        public string TransText { get; set; }
        public bool CustomTrans { get; set; }
        public string SortTransText { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
