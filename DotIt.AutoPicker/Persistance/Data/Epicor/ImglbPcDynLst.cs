using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPcDynLst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string InputName { get; set; }
        public int ListSeq { get; set; }
        public string Condition { get; set; }
        public string ListItems { get; set; }
        public string InitVal { get; set; }
        public bool DlrunProgram { get; set; }
        public string DlprogramName { get; set; }
        public string DlprogramInputs { get; set; }
        public bool BaqrunProgram { get; set; }
        public string BaqprogramName { get; set; }
        public string BaqdispValue { get; set; }
        public string BaqinputVal { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public string ConfigId { get; set; }
        public bool TblLookup { get; set; }
        public string TblLookupId { get; set; }
        public string TblLookupFunc { get; set; }
        public string TblLookupRowSetId { get; set; }
        public string TblLookupColId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SortOrder { get; set; }
        public string SubReturnColumn { get; set; }
        public string ScriptCondition { get; set; }
        public string AttributeId { get; set; }
    }
}
