using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imabthist
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Abtuid { get; set; }
        public int DocLineIndex { get; set; }
        public string DocLinePath { get; set; }
        public string Path { get; set; }
        public string DataValue { get; set; }
        public string DataType { get; set; }
        public int DocLineUid { get; set; }
        public int AmountIndex { get; set; }
        public int Level { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
