using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Pdmsyst
    {
        public string Company { get; set; }
        public string PdmexportDir { get; set; }
        public string PdmimportDir { get; set; }
        public string DocExportDir { get; set; }
        public string DocImportDir { get; set; }
        public string EcogroupId { get; set; }
        public string RevisionNum { get; set; }
        public string SearchWord { get; set; }
        public int FileNum { get; set; }
        public string PartPrefix { get; set; }
        public string BomPrefix { get; set; }
        public string DocPrefix { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Plmrevision { get; set; }
    }
}
