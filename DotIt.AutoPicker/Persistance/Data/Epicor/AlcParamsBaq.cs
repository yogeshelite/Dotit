using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlcParamsBaq
    {
        public string Company { get; set; }
        public string BookId { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public int BaqparamValNbr { get; set; }
        public string BaqexportId { get; set; }
        public string ParameterName { get; set; }
        public string BaqparamCode { get; set; }
        public int ParamOpt { get; set; }
        public int ParamSegmentNbr { get; set; }
        public string Coacode { get; set; }
        public int EntryType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
