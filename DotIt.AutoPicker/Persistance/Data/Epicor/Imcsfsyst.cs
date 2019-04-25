using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imcsfsyst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxInfo1 { get; set; }
        public string TaxInfo2 { get; set; }
        public string TaxInfo3 { get; set; }
        public string TaxInfo4 { get; set; }
        public string TaxInfo5 { get; set; }
        public string TaxInfo6 { get; set; }
        public string TaxInfo7 { get; set; }
        public string TaxInfo8 { get; set; }
        public string TaxInfo9 { get; set; }
        public string TaxInfo10 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string RedStornoOpt { get; set; }
    }
}
