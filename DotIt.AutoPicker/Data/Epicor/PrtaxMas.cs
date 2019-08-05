using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrtaxMas
    {
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
