using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SalesTrc
    {
        public string Company { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public string Description { get; set; }
        public bool DefaultRate { get; set; }
        public string TextCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Agafipcode { get; set; }
        public string Agfeafipcode { get; set; }
        public int AgpurchaseColNumber { get; set; }
        public int AgsalesColNumber { get; set; }
        public string BeintracomCode { get; set; }
        public bool JpconsumptionTax { get; set; }
        public string Plsaftcode { get; set; }
        public string Codiancode { get; set; }
    }
}
