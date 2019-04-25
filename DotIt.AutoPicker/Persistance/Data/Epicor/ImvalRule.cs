using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImvalRule
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
