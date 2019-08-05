using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImnltaxReportDeclarationDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int DeclarationUid { get; set; }
        public string BoxCode { get; set; }
        public decimal BoxSysTaxableAmt { get; set; }
        public decimal BoxSysTaxAmt { get; set; }
        public decimal BoxTaxableAmt { get; set; }
        public decimal BoxTaxAmt { get; set; }
        public decimal DocBoxSysTaxableAmt { get; set; }
        public decimal DocBoxSysTaxAmt { get; set; }
        public decimal DocBoxTaxableAmt { get; set; }
        public decimal DocBoxTaxAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
