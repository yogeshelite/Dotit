﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SugPoDtl
    {
        public string Company { get; set; }
        public int SugNum { get; set; }
        public string SugType { get; set; }
        public string BuyerId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal XrelQty { get; set; }
        public decimal PurchasingFactor { get; set; }
        public decimal RelQty { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int JobSeq { get; set; }
        public string WarehouseCode { get; set; }
        public string Fob { get; set; }
        public string ShipViaCode { get; set; }
        public string TermsCode { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public bool Taxable { get; set; }
        public string Pum { get; set; }
        public string CostPerCode { get; set; }
        public string PartNum { get; set; }
        public string VenPartNum { get; set; }
        public string CommentText { get; set; }
        public string ClassId { get; set; }
        public string RevisionNum { get; set; }
        public string VendorId { get; set; }
        public string Name { get; set; }
        public bool Buy { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public string OpCode { get; set; }
        public DateTime? OrderByDate { get; set; }
        public int LeadTime { get; set; }
        public int ReqNum { get; set; }
        public int ReqLine { get; set; }
        public string Plant { get; set; }
        public bool CreateRfq { get; set; }
        public bool SourceRfq { get; set; }
        public string GlbCompany { get; set; }
        public int GlbSugNum { get; set; }
        public bool GlbSuggestion { get; set; }
        public string PurchasingFactorDirection { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public bool DropShip { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public string ShipToNum { get; set; }
        public int SoldToNum { get; set; }
        public int ShpConNum { get; set; }
        public int ShipToCustNum { get; set; }
        public string ComplianceMsg { get; set; }
        public bool PorelOpen { get; set; }
        public string SugReason { get; set; }
        public string Abccode { get; set; }
        public string Direction { get; set; }
        public string Per { get; set; }
        public bool ManualFactor { get; set; }
        public decimal Factor { get; set; }
        public decimal PricingQty { get; set; }
        public decimal PricingUnitPrice { get; set; }
        public string Uom { get; set; }
        public string UrgentPlanning { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool MaintainPricingUnits { get; set; }
        public string CurrencyCode { get; set; }
        public bool Review { get; set; }
        public bool OverridePriceList { get; set; }
        public string ContractId { get; set; }
        public bool LinkToContract { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public int DemandScheduleSeq { get; set; }
        public bool EpicorFsa { get; set; }

        public virtual SugPoDtlUd SugPoDtlUd { get; set; }
    }
}
