using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Abtqparam
    {
        public int BaqparamLinkUid { get; set; }
        public int AbtqueryUid { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public string Company { get; set; }
        public string Baqparam { get; set; }
        public string Abtbaqparam { get; set; }
        public int AbtdocLineUid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
