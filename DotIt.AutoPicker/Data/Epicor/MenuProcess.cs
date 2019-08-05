﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MenuProcess
    {
        public MenuProcess()
        {
            MenuLayout = new HashSet<MenuLayout>();
        }

        public string Company { get; set; }
        public string MenuProcessId { get; set; }
        public string Cgccode { get; set; }
        public string ProcessType { get; set; }
        public string SystemCode { get; set; }
        public bool Delivered { get; set; }
        public string FormName { get; set; }
        public string Program { get; set; }
        public string Arguments { get; set; }
        public bool Enabled { get; set; }
        public bool ReadOnly { get; set; }
        public string DashboardId { get; set; }
        public string Report { get; set; }
        public string CustomizationType { get; set; }
        public string Customization { get; set; }
        public string Icon { get; set; }
        public string MenuDesc { get; set; }
        public string SecCode { get; set; }
        public string LongDesc { get; set; }
        public string Module { get; set; }
        public string Options { get; set; }
        public bool Udenabled { get; set; }
        public bool UdreadOnly { get; set; }
        public string UddashboardId { get; set; }
        public string Udreport { get; set; }
        public string UdcustomizationType { get; set; }
        public string Udcustomization { get; set; }
        public string Udoptions { get; set; }
        public string Udicon { get; set; }
        public string UdmenuDesc { get; set; }
        public string UdsecCode { get; set; }
        public string UdlongDesc { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<MenuLayout> MenuLayout { get; set; }
    }
}
