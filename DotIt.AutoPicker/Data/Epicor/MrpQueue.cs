using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MrpQueue
    {
        public string Company { get; set; }
        public string ProcessType { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string QueueIn { get; set; }
        public string QueueOut { get; set; }
        public string CheckGrp { get; set; }
        public string Qmessage { get; set; }
        public string Qstatus { get; set; }
        public string GroupId { get; set; }
        public bool Controller { get; set; }
        public bool Regen { get; set; }
        public bool LevelRepeat { get; set; }
        public bool Finite { get; set; }
        public string QstatusMsg { get; set; }
        public bool SystemProc { get; set; }
        public string ExtProcName { get; set; }
        public string AltQout1 { get; set; }
        public string AltQout2 { get; set; }
        public string AltQout3 { get; set; }
        public string AltQout4 { get; set; }
        public string AltQout5 { get; set; }
        public string AltQin1 { get; set; }
        public string AltQin2 { get; set; }
        public string AltQin3 { get; set; }
        public string AltQin4 { get; set; }
        public string AltQin5 { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
