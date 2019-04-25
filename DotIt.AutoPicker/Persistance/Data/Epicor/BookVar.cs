using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BookVar
    {
        public int ActtypeUid { get; set; }
        public int ActrevisionUid { get; set; }
        public string BookId { get; set; }
        public int BookVarUid { get; set; }
        public string VarName { get; set; }
        public string VarType { get; set; }
        public string VType { get; set; }
        public int VUid { get; set; }
        public string Company { get; set; }
        public bool IsDefault { get; set; }
        public bool LocModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
