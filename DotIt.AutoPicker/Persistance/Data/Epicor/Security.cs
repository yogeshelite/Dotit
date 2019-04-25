using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Security
    {
        public string Company { get; set; }
        public string SecCode { get; set; }
        public string EntryList { get; set; }
        public string NoEntryList { get; set; }
        public bool SecurityMgr { get; set; }
        public string Description { get; set; }
        public string ParentSecCode { get; set; }
        public int ParentSeqNum { get; set; }
        public bool Disconnected { get; set; }
        public bool ShipRecv { get; set; }
        public bool ShopSupervisor { get; set; }
        public bool MaterialHandler { get; set; }
        public bool ProductionWorker { get; set; }
        public bool ServTech { get; set; }
        public bool CustWebAvailable { get; set; }
        public string Cgccode { get; set; }
        public string SystemCode { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool GlobalSecurityMgr { get; set; }
        public int CompanyVisibility { get; set; }
    }
}
