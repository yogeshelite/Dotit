using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImfamethodParamsBaq
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
