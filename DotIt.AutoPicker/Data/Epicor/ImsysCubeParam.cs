using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImsysCubeParam
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public int Sequence { get; set; }
        public string Dimension1Id { get; set; }
        public string Dimension1 { get; set; }
        public string Dimension2Id { get; set; }
        public string Dimension2 { get; set; }
        public string Dimension2Date { get; set; }
        public string ValueDec01 { get; set; }
        public string ValueDec02 { get; set; }
        public string ValueDec03 { get; set; }
        public string ValueDec04 { get; set; }
        public string ValueDec05 { get; set; }
        public string ValueDec06 { get; set; }
        public string ValueDec07 { get; set; }
        public string ValueDec08 { get; set; }
        public string ValueDec09 { get; set; }
        public string ValueDec10 { get; set; }
        public string ValueInt01 { get; set; }
        public string ValueInt02 { get; set; }
        public string ValueInt03 { get; set; }
        public string ValueInt04 { get; set; }
        public string ValueInt05 { get; set; }
        public string SysShortChar01 { get; set; }
        public string SysShortChar02 { get; set; }
        public string SysShortChar03 { get; set; }
        public string SysShortChar04 { get; set; }
        public string SysShortChar05 { get; set; }
        public string SysShortChar06 { get; set; }
        public string SysShortChar07 { get; set; }
        public string SysShortChar08 { get; set; }
        public string SysShortChar09 { get; set; }
        public string SysShortChar10 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }
    }
}
