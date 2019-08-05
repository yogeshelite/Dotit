using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysActivityLog
    {
        public int ActivitySeq { get; set; }
        public string Company { get; set; }
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
        public DateTime? LastActivityOn { get; set; }
        public string UserId { get; set; }
        public string ActivityType { get; set; }
        public string ActivityProject { get; set; }
        public string ActivityComment { get; set; }
        public string OrigCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
