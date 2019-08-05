using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class NamedSearch
    {
        public string Company { get; set; }
        public string SearchForm { get; set; }
        public string Nsid { get; set; }
        public string UserId { get; set; }
        public string CalledFrom { get; set; }
        public bool IsDefault { get; set; }
        public bool AutoExecute { get; set; }
        public bool UnpinCrit { get; set; }
        public bool IsShared { get; set; }
        public string ShareType { get; set; }
        public bool ReturnAll { get; set; }
        public int MaxRows { get; set; }
        public bool AutoSelect { get; set; }
        public string DataSetMode { get; set; }
        public string Description { get; set; }
        public string ProductId { get; set; }
        public string ActiveTab { get; set; }
        public bool GroupOn { get; set; }
        public string GroupBy { get; set; }
        public string SearchType { get; set; }
        public string SearchUsing { get; set; }
        public string SortByColumn { get; set; }
        public string SortOrder { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
