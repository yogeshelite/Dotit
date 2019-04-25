using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EccextendedDtl
    {
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

        public virtual Eccextended Eccextended { get; set; }
    }
}
