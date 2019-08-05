using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ValRule
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string RefTable { get; set; }
        public string RefFields { get; set; }
        public string ForeignFields { get; set; }
        public bool MandatoryEntry { get; set; }
        public bool SystemRule { get; set; }
        public string ValPhraseExt { get; set; }
        public bool DelimeterCheck { get; set; }
        public string ValidationComments { get; set; }
        public bool Vantage { get; set; }
        public bool Vista { get; set; }
        public string CodeDescriptionList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
