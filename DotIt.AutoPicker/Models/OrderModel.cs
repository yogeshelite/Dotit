using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Models
{


    public class OrderHeadModel
    {
      
        //OrderNum(int, optional),
        public bool OpenOrder { get; set; }
        public int OrderNum { get; set; }
        public string OrderComment { get; set; }


        //CustNum(int, optional),
        public int CustNum { get; set; }

        private int _TotalLine;

        public int TotalLines
        {
            get { return _TotalLine; }
            set { _TotalLine = (OrderDtls != null) ? OrderDtls.Count : value;  }
        }


   
        //PONum (string, optional),
        public string PONum { get; set; }

        //OrderDate (string, optional),
        public string OrderDate { get; set; }

        //RequestDate (string, optional),
        public DateTime RequestDate { get; set; }

        // field for OrderDate in DateTime Format
        public DateTime OrderDateTime { get; set; }

        //Company (string, optional),
        public string Company { get; set; }


        public Double Weight { get; set; }
        public Double? TotalWgt_c { get; set; }



        //Field for storing Status of a order
        public string OrderPickStatus { get; set; }

        //Field for storing Pick Date Time
        public DateTime PickDate { get; set; }

        //Field for storing UserId
        public string PickerUserId { get; set; }
        public List<OrderDetailModel> OrderDtls { get; set; }


    }
    public class OrderDetailModel
    {
        public Guid OrderDetailID { get; set; }

        public string OrderPickStatus { get; set; }
        public string PlantName { get; set; }
        public string WhseCodeDesc { get; set; }
        public string BinDesc { get; set; }
        public string LotNumberDesc { get; set; }
        public string DimCodeDesc { get; set; }
        public string NonNettable { get; set; }
        public string BinType { get; set; }
        public string PCID { get; set; }
        public string SendToFSA { get; set; }
        public string LotNumber { get; set; }
        public string QtyOnHand { get; set; }
        public string PartDesc { get; set; }
        public string Plant { get; set; }
        public string WhseCode { get; set; }

        public float BoxWeight_c { get; set; }
        public bool VoidLine { get; set; }
        public bool OpenLine { get; set; }
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string LineType { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string Reference { get; set; }
        public string IUM { get; set; }
        public string RevisionNum { get; set; }
        public string POLine { get; set; }
        public bool Commissionable { get; set; }
        public float DiscountPercent { get; set; }
        public float UnitPrice { get; set; }
        public float DocUnitPrice { get; set; }
        public float OrderQty { get; set; }
        public float Discount { get; set; }
        public float DocDiscount { get; set; }
        public string RequestDate { get; set; }
        public string ProdCode { get; set; }
        public string XPartNum { get; set; }
        public string XRevisionNum { get; set; }
        public string PricePerCode { get; set; }
        public string OrderComment { get; set; }
        public string ShipComment { get; set; }
        public string InvoiceComment { get; set; }
        public string PickListComment { get; set; }
        public string TaxCatID { get; set; }
        public float AdvanceBillBal { get; set; }
        public float DocAdvanceBillBal { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public bool TMBilling { get; set; }
        public string OrigWhyNoTax { get; set; }
        public string NeedByDate { get; set; }
        public int CustNum { get; set; }
        public bool Rework { get; set; }
        public int RMANum { get; set; }
        public int RMALine { get; set; }
        public string ProjectID { get; set; }
        public int ContractNum { get; set; }
        public string ContractCode { get; set; }
        public string BasePartNum { get; set; }
        public bool Warranty { get; set; }
        public string WarrantyCode { get; set; }
        public int MaterialDuration { get; set; }
        public int LaborDuration { get; set; }
        public int MiscDuration { get; set; }
        public string MaterialMod { get; set; }
        public string LaborMod { get; set; }
        public string WarrantyComment { get; set; }
        public bool Onsite { get; set; }
        public bool MatCovered { get; set; }
        public bool LabCovered { get; set; }
        public bool MiscCovered { get; set; }
        public string SalesUM { get; set; }
        public float SellingFactor { get; set; }
        public float SellingQuantity { get; set; }
        public string SalesCatID { get; set; }
        public bool ShipLineComplete { get; set; }
        public float CumeQty { get; set; }
        public string CumeDate { get; set; }
        public string MktgCampaignID { get; set; }
        public int MktgEvntSeq { get; set; }
        public bool LockQty { get; set; }
        public bool Linked { get; set; }
        public int ICPONum { get; set; }
        public int ICPOLine { get; set; }
        public string ExtCompany { get; set; }
        public string LastConfigDate { get; set; }
        public int LastConfigTime { get; set; }
        public string LastConfigUserID { get; set; }
        public float ConfigUnitPrice { get; set; }
        public float ConfigBaseUnitPrice { get; set; }
        public string PriceListCode { get; set; }
        public string BreakListCode { get; set; }
        public float PricingQty { get; set; }
        public bool LockPrice { get; set; }
        public float ListPrice { get; set; }
        public float DocListPrice { get; set; }
        public float OrdBasedPrice { get; set; }
        public float DocOrdBasedPrice { get; set; }
        public string PriceGroupCode { get; set; }
        public bool OverridePriceList { get; set; }
        public string BaseRevisionNum { get; set; }
        public float PricingValue { get; set; }
        public float DisplaySeq { get; set; }
        public int KitParentLine { get; set; }
        public bool KitAllowUpdate { get; set; }
        public bool KitShipComplete { get; set; }
        public bool KitBackFlush { get; set; }
        public bool KitPrintCompsPS { get; set; }
        public bool KitPrintCompsInv { get; set; }
        public string KitPricing { get; set; }
        public float KitQtyPer { get; set; }
        public string SellingFactorDirection { get; set; }
        public float RepRate1 { get; set; }
        public float RepRate2 { get; set; }
        public float RepRate3 { get; set; }
        public float RepRate4 { get; set; }
        public float RepRate5 { get; set; }
        public int RepSplit1 { get; set; }
        public int RepSplit2 { get; set; }
        public int RepSplit3 { get; set; }
        public int RepSplit4 { get; set; }
        public int RepSplit5 { get; set; }
        public int DemandContractLine { get; set; }
        public bool CreateNewJob { get; set; }
        public string DoNotShipBeforeDate { get; set; }
        public bool GetDtls { get; set; }
        public string DoNotShipAfterDate { get; set; }
        public bool SchedJob { get; set; }
        public bool RelJob { get; set; }
        public bool EnableCreateNewJob { get; set; }
        public bool EnableGetDtls { get; set; }
        public bool EnableSchedJob { get; set; }
        public bool EnableRelJob { get; set; }
        public string CounterSaleWarehouse { get; set; }
        public string CounterSaleBinNum { get; set; }
        public string CounterSaleLotNum { get; set; }
        public string CounterSaleDimCode { get; set; }
        public bool DemandDtlRejected { get; set; }
        public string KitFlag { get; set; }
        public bool KitsLoaded { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public string ChangedBy { get; set; }
        public string ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool ReverseCharge { get; set; }
        public int TotalReleases { get; set; }
        public float Rpt1UnitPrice { get; set; }
        public float Rpt2UnitPrice { get; set; }
        public float Rpt3UnitPrice { get; set; }
        public float Rpt1Discount { get; set; }
        public float Rpt2Discount { get; set; }
        public float Rpt3Discount { get; set; }
        public float Rpt1AdvanceBillBal { get; set; }
        public float Rpt2AdvanceBillBal { get; set; }
        public float Rpt3AdvanceBillBal { get; set; }
        public float Rpt1ListPrice { get; set; }
        public float Rpt2ListPrice { get; set; }
        public float Rpt3ListPrice { get; set; }
        public float Rpt1OrdBasedPrice { get; set; }
        public float Rpt2OrdBasedPrice { get; set; }
        public float Rpt3OrdBasedPrice { get; set; }
        public float ExtPriceDtl { get; set; }
        public float DocExtPriceDtl { get; set; }
        public float Rpt1ExtPriceDtl { get; set; }
        public float Rpt2ExtPriceDtl { get; set; }
        public float Rpt3ExtPriceDtl { get; set; }
        public string LineStatus { get; set; }
        public float InUnitPrice { get; set; }
        public float DocInUnitPrice { get; set; }
        public float InDiscount { get; set; }
        public float DocInDiscount { get; set; }
        public float InListPrice { get; set; }
        public float DocInListPrice { get; set; }
        public float InOrdBasedPrice { get; set; }
        public float DocInOrdBasedPrice { get; set; }
        public float Rpt1InUnitPrice { get; set; }
        public float Rpt2InUnitPrice { get; set; }
        public float Rpt3InUnitPrice { get; set; }
        public float Rpt1InDiscount { get; set; }
        public float Rpt2InDiscount { get; set; }
        public float Rpt3InDiscount { get; set; }
        public float Rpt1InListPrice { get; set; }
        public float Rpt2InListPrice { get; set; }
        public float Rpt3InListPrice { get; set; }
        public float Rpt1InOrdBasedPrice { get; set; }
        public float Rpt2InOrdBasedPrice { get; set; }
        public float Rpt3InOrdBasedPrice { get; set; }
        public float InExtPriceDtl { get; set; }
        public float DocInExtPriceDtl { get; set; }
        public float Rpt1InExtPriceDtl { get; set; }
        public float Rpt2InExtPriceDtl { get; set; }
        public float Rpt3InExtPriceDtl { get; set; }
        public float OldOurOpenQty { get; set; }
        public float OldSellingOpenQty { get; set; }
        public float OldOpenValue { get; set; }
        public string OldProdCode { get; set; }
        public float PrevSellQty { get; set; }
        public string PrevPartNum { get; set; }
        public string PrevXPartNum { get; set; }
        public int KitCompOrigSeq { get; set; }
        public string KitCompOrigPart { get; set; }
        public bool SmartStringProcessed { get; set; }
        public string SmartString { get; set; }
        public int RenewalNbr { get; set; }
        public string DiscBreakListCode { get; set; }
        public float DiscListPrice { get; set; }
        public bool LockDisc { get; set; }
        public bool OverrideDiscPriceList { get; set; }
        public int GroupSeq { get; set; }
        public string ECCOrderNum { get; set; }
        public int ECCOrderLine { get; set; }
        public bool DupOnJobCrt { get; set; }
        public float UndersPct { get; set; }
        public float Overs { get; set; }
        public float Unders { get; set; }
        public float OversUnitPrice { get; set; }
        public string PlanUserID { get; set; }
        public string PlanGUID { get; set; }
        public string MOMsourceType { get; set; }
        public string MOMsourceEst { get; set; }
        public string DefaultOversPricing { get; set; }
        public string ECCPlant { get; set; }
        public string ECCQuoteNum { get; set; }
        public int ECCQuoteLine { get; set; }
        public int SysRevID { get; set; }
        public string SysRowID { get; set; }
        public string MfgJobType { get; set; }
        public string ProFormaInvComment { get; set; }
        public bool CreateJob { get; set; }
        public string ContractID { get; set; }
        public bool LinkToContract { get; set; }
        public float DocInAdvanceBillBal { get; set; }
        public float InAdvanceBillBal { get; set; }
        public float Rpt1InAdvanceBillBal { get; set; }
        public float Rpt2InAdvanceBillBal { get; set; }
        public float Rpt3InAdvanceBillBal { get; set; }
        public bool PCLinkRemoved { get; set; }
        public string CommodityCode { get; set; }
        public float MSRP { get; set; }
        public float DocMSRP { get; set; }
        public float Rpt1MSRP { get; set; }
        public float Rpt2MSRP { get; set; }
        public float Rpt3MSRP { get; set; }
        public float EndCustomerPrice { get; set; }
        public float DocEndCustomerPrice { get; set; }
        public float Rpt1EndCustomerPrice { get; set; }
        public float Rpt2EndCustomerPrice { get; set; }
        public float Rpt3EndCustomerPrice { get; set; }
        public float PromotionalPrice { get; set; }
        public float DocPromotionalPrice { get; set; }
        public float Rpt1PromotionalPrice { get; set; }
        public float Rpt2PromotionalPrice { get; set; }
        public float Rpt3PromotionalPrice { get; set; }
        public string OrderLineStatusCode { get; set; }
        public string BinNum { get; set; }
        public string ConfigType { get; set; }
        public string Configured { get; set; }
        public bool CounterSale { get; set; }
        public string CreditLimitMessage { get; set; }
        public string CreditLimitSource { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyID { get; set; }
        public bool CurrencySwitch { get; set; }
        public string CurrSymbol { get; set; }
        public float DemandQuantity { get; set; }
        public string DimCode { get; set; }
        public float DimConvFactor { get; set; }
        public float DocDspDiscount { get; set; }
        public float DocDspUnitPrice { get; set; }
        public float DocExtPrice { get; set; }
        public float DocInMiscCharges { get; set; }
        public float DocLessDiscount { get; set; }
        public float DocMiscCharges { get; set; }
        public float DocTaxAmt { get; set; }
        public float DocTotalPrice { get; set; }
        public float DspDiscount { get; set; }
        public string DspJobType { get; set; }
        public float DspUnitPrice { get; set; }
        public string DUM { get; set; }
        public string ECCConfigSysRowId { get; set; }
        public float ECCDiscount { get; set; }
        public bool ECCPreventRepricing { get; set; }
        public bool EnableDynAttrButton { get; set; }
        public bool EnableKitUnitPrice { get; set; }
        public bool EnableRenewalNbr { get; set; }
        public bool EnableSellingQty { get; set; }
        public string EntryProcess { get; set; }
        public float ExtPrice { get; set; }
        public bool FromQuoteLineFlag { get; set; }
        public float FSAInstallationCost { get; set; }
        public int FSAInstallationOrderLine { get; set; }
        public int FSAInstallationOrderNum { get; set; }
        public bool FSAInstallationRequired { get; set; }
        public string FSAInstallationType { get; set; }
        public string FSAInstallationTypeDescription { get; set; }
        public bool HasComplement { get; set; }
        public bool HasDowngrade { get; set; }
        public bool HasSubstitute { get; set; }
        public bool HasUpgrade { get; set; }
        public float InMiscCharges { get; set; }
        public bool InPrice { get; set; }
        public string InvtyUOM { get; set; }
        public string JobTypeDesc { get; set; }
        public bool JobWasCreated { get; set; }
        public bool KitChangeParms { get; set; }
        public bool KitDisable { get; set; }
        public string KitFlagDescription { get; set; }
        public string KitOrderQtyUOM { get; set; }
        public bool KitStandard { get; set; }
        public float LessDiscount { get; set; }
        public string LotNum { get; set; }
        public float MiscCharges { get; set; }
        public bool MultipleReleases { get; set; }
        public float OnHandQuantity { get; set; }
        public bool PartExists { get; set; }
        public bool PartTrackDimension { get; set; }
        public bool PartTrackLots { get; set; }
        public string POLineRef { get; set; }
        public string PriceListCodeDesc { get; set; }
        public bool ProcessCounterSale { get; set; }
        public bool ProcessQuickEntry { get; set; }
        public int QuoteQtyNum { get; set; }
        public bool RelWasRecInvoiced { get; set; }
        public string RespMessage { get; set; }
        public float Rpt1DspDiscount { get; set; }
        public float Rpt1DspUnitPrice { get; set; }
        public float Rpt1ExtPrice { get; set; }
        public float Rpt1InMiscCharges { get; set; }
        public float Rpt1LessDiscount { get; set; }
        public float Rpt1MiscCharges { get; set; }
        public float Rpt1TaxAmt { get; set; }
        public float Rpt1TotalPrice { get; set; }
        public float Rpt2DspDiscount { get; set; }
        public float Rpt2DspUnitPrice { get; set; }
        public float Rpt2ExtPrice { get; set; }
        public float Rpt2InMiscCharges { get; set; }
        public float Rpt2LessDiscount { get; set; }
        public float Rpt2MiscCharges { get; set; }
        public float Rpt2TaxAmt { get; set; }
        public float Rpt2TotalPrice { get; set; }
        public float Rpt3DspDiscount { get; set; }
        public float Rpt3DspUnitPrice { get; set; }
        public float Rpt3ExtPrice { get; set; }
        public float Rpt3InMiscCharges { get; set; }
        public float Rpt3LessDiscount { get; set; }
        public float Rpt3MiscCharges { get; set; }
        public float Rpt3TaxAmt { get; set; }
        public float Rpt3TotalPrice { get; set; }
        public string SalesRepName1 { get; set; }
        public string SalesRepName2 { get; set; }
        public string SalesRepName3 { get; set; }
        public string SalesRepName4 { get; set; }
        public string SalesRepName5 { get; set; }
        public float TaxAmt { get; set; }
        public float ThisOrderInvtyQty { get; set; }
        public float TotalPrice { get; set; }
        public float TotalShipped { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDesc { get; set; }
        public float AvailableQuantity { get; set; }
        public string AvailPriceLists { get; set; }
        public string AvailUMFromQuote { get; set; }
        public string BaseCurrencyID { get; set; }
        public string BaseCurrSymbol { get; set; }
        public float CalcUnitPrice { get; set; }
        public string IntExternalKey { get; set; }
        public int BitFlag { get; set; }
        public string CommodityCodeDescription { get; set; }
        public string ContractCodeContractDescription { get; set; }
        public bool CustNumSendToFSA { get; set; }
        public string CustNumBTName { get; set; }
        public string CustNumCustID { get; set; }
        public string CustNumName { get; set; }
        public string DiscBreakListCodeListDescription { get; set; }
        public string DiscBreakListCodeEndDate { get; set; }
        public string DiscBreakListCodeStartDate { get; set; }
        public string MktgCampaignIDCampDescription { get; set; }
        public string MktgEvntEvntDescription { get; set; }
        public int OrderNumBTCustNum { get; set; }
        public string OrderNumCurrencyCode { get; set; }
        public string OrderNumCardMemberName { get; set; }
        public bool PartNumSendToFSA { get; set; }
        public string PartNumSalesUM { get; set; }
        public string PartNumPricePerCode { get; set; }
        public bool PartNumTrackSerialNum { get; set; }
        public string PartNumPartDescription { get; set; }
        public string PartNumIUM { get; set; }
        public bool PartNumTrackLots { get; set; }
        public float PartNumSellingFactor { get; set; }
        public bool PartNumTrackDimension { get; set; }
        public bool PartNumFSAEquipment { get; set; }
        public string PriceBreakListDescription { get; set; }
        public string PriceBreakStartDate { get; set; }
        public string PriceBreakEndDate { get; set; }
        public string ProdCodeDescription { get; set; }
        public string ProjectIDDescription { get; set; }
        public string QuoteNumCurrencyCode { get; set; }
        public string SalesCatIDDescription { get; set; }
        public string TaxCatIDDescription { get; set; }
        public string WarrantyCodeWarrDescription { get; set; }
        public string RowMod { get; set; }
        public int ShipBoxfloat_c { get; set; }
        public string UD_SysRevID { get; set; }
        public float NetWeight_c { get; set; }
        public string OriginalOrderLine_c { get; set; }
        public string PartShipComment_c { get; set; }
        public string ImageContent { get; set; }

    }
}