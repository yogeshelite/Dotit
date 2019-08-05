using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class NcchgLog
    {
        public string Identifier { get; set; }
        public string TableName { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string Key6 { get; set; }
        public string Key7 { get; set; }
        public string Key8 { get; set; }
        public string Key9 { get; set; }
        public string Key10 { get; set; }
        public DateTime DateStamp { get; set; }
        public string LogText { get; set; }
        public int Dblevel { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
