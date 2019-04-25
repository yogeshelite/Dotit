using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Brfunction
    {
        public int FunctionUid { get; set; }
        public string Name { get; set; }
        public string Prgname { get; set; }
        public bool IsSystem { get; set; }
        public string Description { get; set; }
        public string ResultType { get; set; }
        public string Prgpattern { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public string BookId { get; set; }
        public string Formula { get; set; }
        public string Company { get; set; }
        public string DocLinePath { get; set; }
        public bool IsDefault { get; set; }
        public bool ManuallyUpdVer { get; set; }
        public int FuncVer { get; set; }
        public int PatchFuncVer { get; set; }
        public bool PrevModified { get; set; }
        public bool Modified { get; set; }
        public int LocVer { get; set; }
        public int LocPatchVer { get; set; }
        public bool LocModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
