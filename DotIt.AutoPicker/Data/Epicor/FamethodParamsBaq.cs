using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FamethodParamsBaq
    {
        public string Company { get; set; }
        public string AssetMethod { get; set; }
        public int ParamNbr { get; set; }
        public string BaqexportId { get; set; }
        public int BaqparamValNbr { get; set; }
        public string ParameterName { get; set; }
        public string BaqparamCode { get; set; }
        public int ParamOpt { get; set; }
        public int ParamSegmentNbr { get; set; }
        public int EntryType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
