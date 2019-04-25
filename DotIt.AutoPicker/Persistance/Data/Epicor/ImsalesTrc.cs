using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsalesTrc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
