using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImdropShipDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string VenPartNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public decimal OurQty { get; set; }
        public string Ium { get; set; }
        public string LotNum { get; set; }
        public string ShipComment { get; set; }
        public string InvoiceComment { get; set; }
        public string HeaderShipComment { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangedBy { get; set; }
        public int ChangeTime { get; set; }
        public bool Complete { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string LineDesc { get; set; }
        public decimal OurUnitCost { get; set; }
        public decimal DocUnitCost { get; set; }
        public decimal VendorQty { get; set; }
        public string Pum { get; set; }
        public decimal VendorUnitCost { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public bool Apinvoiced { get; set; }
        public bool Arinvoiced { get; set; }
        public string ApinvoiceNum { get; set; }
        public int ApinvoiceLine { get; set; }
        public int ArinvoiceNum { get; set; }
        public int ArinvoiceLine { get; set; }
        public string CostPerCode { get; set; }
        public string TranReference { get; set; }
        public string RefType { get; set; }
        public string PurchCode { get; set; }
        public bool ReceivedShipped { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool LabCovered { get; set; }
        public int LaborDuration { get; set; }
        public DateTime? LaborExpiration { get; set; }
        public string LaborMod { get; set; }
        public DateTime? LastExpiration { get; set; }
        public bool MatCovered { get; set; }
        public int MaterialDuration { get; set; }
        public DateTime? MaterialExpiration { get; set; }
        public string MaterialMod { get; set; }
        public bool MiscCovered { get; set; }
        public int MiscDuration { get; set; }
        public DateTime? MiscExpiration { get; set; }
        public string MiscMod { get; set; }
        public bool Onsite { get; set; }
        public string WarrantyCode { get; set; }
        public string WarrantyComment { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ProjProcessed { get; set; }
    }
}
