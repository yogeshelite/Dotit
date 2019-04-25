using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImeccextendedDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RelatedToSchema { get; set; }
        public string RelatedToTable { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public string ChildSchema { get; set; }
        public string ChildTableName { get; set; }
        public Guid ChildSysRowId { get; set; }
        public decimal DealerBasePrice { get; set; }
        public decimal DealerPrice { get; set; }
        public decimal DealerPriceInc { get; set; }
        public decimal DealerLineValue { get; set; }
        public decimal DealerLineValueInc { get; set; }
        public decimal DealerLineDiscount { get; set; }
        public string DealerTaxCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
