using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imeccextended
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
        public string EccsiteName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Dealer { get; set; }
        public decimal DealerGoodsTotal { get; set; }
        public decimal DealerGoodsTotalInc { get; set; }
        public decimal DealerDiscountAmount { get; set; }
        public decimal DealerCarriageAmount { get; set; }
        public decimal DealerCarriageAmountInc { get; set; }
        public decimal DealerGrandTotal { get; set; }
        public decimal DealerGrandTotalInc { get; set; }
        public string EccsiteUrl { get; set; }
        public bool SavedToken { get; set; }
        public string EccpaymentMethod { get; set; }
        public string TranType { get; set; }
    }
}
