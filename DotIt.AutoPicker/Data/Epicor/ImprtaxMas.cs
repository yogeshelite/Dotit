using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImprtaxMas
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxTblId { get; set; }
        public string TaxType { get; set; }
        public int CalcOrder { get; set; }
        public string Description { get; set; }
        public string W2state { get; set; }
        public bool EmployerExp { get; set; }
        public string TaxId { get; set; }
        public bool UnemploymentIns { get; set; }
        public bool RoundWithholdings { get; set; }
        public string TaxIdref { get; set; }
        public string StateTaxId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
