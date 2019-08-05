using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcPage
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int PageSeq { get; set; }
        public string PageTitle { get; set; }
        public string PromptWhen { get; set; }
        public string OnLeave { get; set; }
        public bool SkipOnLeaveOpl { get; set; }
        public string OnLeave2 { get; set; }
        public string Comments { get; set; }
        public bool ProcessDynLstFirst { get; set; }
        public bool DynLstHigher { get; set; }
        public bool SkipPageProcessOl { get; set; }
        public bool SkipPageNoInputs { get; set; }
        public bool SkipOnLeaveOpe { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public int PWidth { get; set; }
        public int PHeight { get; set; }
        public int DisplaySeq { get; set; }
        public string ConfigId { get; set; }
        public bool ReadOnly { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
