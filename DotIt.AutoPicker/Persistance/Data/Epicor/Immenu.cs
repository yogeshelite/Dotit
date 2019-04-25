using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Immenu
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string MenuId { get; set; }
        public string MenuDesc { get; set; }
        public string ParentMenuId { get; set; }
        public int Sequence { get; set; }
        public string OptionType { get; set; }
        public string OptionSubType { get; set; }
        public string Program { get; set; }
        public bool Enabled { get; set; }
        public string SecCode { get; set; }
        public bool DoNotDisplayInMenu { get; set; }
        public string Arguments { get; set; }
        public string Module { get; set; }
        public string MenuType { get; set; }
        public string Cgccode { get; set; }
        public string DashboardId { get; set; }
        public bool ExpressAvailable { get; set; }
        public string SystemCode { get; set; }
        public string OldProgram { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public bool Crmmenu { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SaaSparam { get; set; }
        public int CompanyVisibility { get; set; }
    }
}
