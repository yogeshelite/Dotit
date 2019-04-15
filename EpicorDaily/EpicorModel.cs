using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicorDaily.Model
{
    public class AuthenticateModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class ResponseModel
    {
        public bool success { get; set; }
        public string Response { get; set; }
    }
    public class OrderRelModel : OrderRelUDModel
    {
        public string Company { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        public string LineType { get; set; }

        public  Nullable< DateTime> ReqDate { get; set; }

        public decimal OurReqQty { get; set; }

        public string ShipToNum { get; set; }

        public string ShipViaCode { get; set; }

        public bool OpenRelease { get; set; }

        public bool FirmRelease { get; set; }

        public bool Make { get; set; }

        public decimal OurJobQty { get; set; }

        public decimal OurJobShippedQty { get; set; }

        public bool VoidRelease { get; set; }

        public decimal OurStockQty { get; set; }

        public string WarehouseCode { get; set; }

        public decimal OurStockShippedQty { get; set; }

        public string PartNum { get; set; }

        public string RevisionNum { get; set; }

        public string TaxExempt { get; set; }

        public int ShpConNum { get; set; }

        public  Nullable< DateTime> NeedByDate { get; set; }

        public string Reference { get; set; }

        public string Plant { get; set; }

        public decimal SellingReqQty { get; set; }

        public decimal SellingJobQty { get; set; }

        public decimal SellingJobShippedQty { get; set; }

        public decimal SellingStockQty { get; set; }

        public decimal SellingStockShippedQty { get; set; }

        public bool SelectForPicking { get; set; }

        public string StagingWarehouseCode { get; set; }

        public string StagingBinNum { get; set; }

        public string PickError { get; set; }

        public decimal CumeQty { get; set; }

        public  Nullable< DateTime> CumeDate { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        public int ICPOLine { get; set; }

        public int ICPORelNum { get; set; }

        public string ExtCompany { get; set; }

        public string ScheduleNumber { get; set; }

        public string MarkForNum { get; set; }

        public string DropShipName { get; set; }

        public string RAN { get; set; }

        public string DemandReference { get; set; }

        public bool DemandSchedRejected { get; set; }

        public  Nullable< DateTime> DatePickTicketPrinted { get; set; }

        public bool ResDelivery { get; set; }

        public bool SatDelivery { get; set; }

        public bool SatPickup { get; set; }

        public bool VerbalConf { get; set; }

        public bool Hazmat { get; set; }

        public bool DocOnly { get; set; }

        public string RefNotes { get; set; }

        public bool ApplyChrg { get; set; }

        public decimal ChrgAmount { get; set; }

        public bool COD { get; set; }

        public bool CODFreight { get; set; }

        public bool CODCheck { get; set; }

        public decimal CODAmount { get; set; }

        public string GroundType { get; set; }

        public bool NotifyFlag { get; set; }

        public string NotifyEMail { get; set; }

        public bool DeclaredIns { get; set; }

        public decimal DeclaredAmt { get; set; }

        public bool ServSatDelivery { get; set; }

        public bool ServSatPickup { get; set; }

        public bool ServSignature { get; set; }

        public bool ServAlert { get; set; }

        public bool ServPOD { get; set; }

        public bool ServAOD { get; set; }

        public bool ServHomeDel { get; set; }

        public string DeliveryType { get; set; }

        public  Nullable< DateTime> ServDeliveryDate { get; set; }

        public string ServPhone { get; set; }

        public string ServInstruct { get; set; }

        public bool ServRelease { get; set; }

        public string ServAuthNum { get; set; }

        public string ServRef1 { get; set; }

        public string ServRef2 { get; set; }

        public string ServRef3 { get; set; }

        public string ServRef4 { get; set; }

        public string ServRef5 { get; set; }

        public bool OverrideCarrier { get; set; }

        public bool OverrideService { get; set; }

        public string DockingStation { get; set; }

        public string Location { get; set; }

        public string TransportID { get; set; }

        public int ShipbyTime { get; set; }

        public string ChangedBy { get; set; }

        public  Nullable< DateTime> ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool TaxConnectCalc { get; set; }

        public bool GetDfltTaxIds { get; set; }

        public string TaxRegionCode { get; set; }

        public bool UseOTS { get; set; }

        public string OTSName { get; set; }

        public string OTSAddress1 { get; set; }

        public string OTSAddress2 { get; set; }

        public string OTSAddress3 { get; set; }

        public string OTSCity { get; set; }

        public string OTSState { get; set; }

        public string OTSZIP { get; set; }

        public string OTSResaleID { get; set; }

        public string OTSContact { get; set; }

        public string OTSFaxNum { get; set; }

        public string OTSPhoneNum { get; set; }

        public int OTSCountryNum { get; set; }

        public string SubShipTo { get; set; }

        public string ShipRouting { get; set; }

        public bool BuyToOrder { get; set; }

        public int VendorNum { get; set; }

        public string PurPoint { get; set; }

        public bool DropShip { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        public bool OpenOrder { get; set; }

        public string OTSSaveAs { get; set; }

        public string OTSSaveCustID { get; set; }

        public bool OTSCustSaved { get; set; }

        public int ShipToCustNum { get; set; }

        public string IUM { get; set; }

        public string SalesUM { get; set; }

        public string RelStatus { get; set; }

        public string ComplianceMsg { get; set; }

        public decimal PrevSellQty { get; set; }

        public string PrevPartNum { get; set; }

        public string PrevXPartNum { get; set; }

        public  Nullable< DateTime> PrevNeedByDate { get; set; }

        public  Nullable< DateTime> PrevReqDate { get; set; }

        public string PrevShipToNum { get; set; }

        public int MFCustNum { get; set; }

        public bool UseOTMF { get; set; }

        public string OTMFName { get; set; }

        public string OTMFAddress1 { get; set; }

        public string OTMFAddress2 { get; set; }

        public string OTMFAddress3 { get; set; }

        public string OTMFCity { get; set; }

        public string OTMFState { get; set; }

        public string OTMFZIP { get; set; }

        public string OTMFContact { get; set; }

        public string OTMFFaxNum { get; set; }

        public string OTMFPhoneNum { get; set; }

        public int OTMFCountryNum { get; set; }

        public string ECCPlant { get; set; }

        public string WIOrderLine { get; set; }

        public string WIOrder { get; set; }

        public string WebSKU { get; set; }

        public bool ShipOvers { get; set; }

        public decimal WIItemPrice { get; set; }

        public decimal WIItemShipCost { get; set; }

        public Binary SysRevID { get; set; }

        public  Guid SysRowID { get; set; }

        public string EntityUseCode { get; set; }

        public string PhaseID { get; set; }

        public string OTSShipToNum { get; set; }

        public bool WasRecInvoiced { get; set; }

        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public bool ReadyToFulfill { get; set; }



    }

    public class OrderRelUDModel
    {
        public string OTSContactEmailc { get; set; }

        public decimal OurShipRatec { get; set; }

        public decimal PublicShipRatec { get; set; }

        public string TrackingNumberc { get; set; }
    }

    public class OrderHeadUDModel
    {


        public string orderTypec { get; set; }

        public string OTSContactEmailc { get; set; }

        public bool MossProcessc { get; set; }

        public int joboridc { get; set; }

        public int jobidc { get; set; }

        public decimal OurShipRatec { get; set; }

        public decimal PublicShipRatec { get; set; }

        public decimal TotalWgtc { get; set; }

        public bool MOPSc { get; set; }

        public DateTime OrderTimec { get; set; }

        public bool FreeShippingc { get; set; }

        public string CustShipCommentc { get; set; }

        public string ShipToShipCommentc { get; set; }




    }


    public class OrderHeadModel : OrderHeadUDModel
    {
        public string orderType_c { get; set; }
        public bool OpenOrder { get; set; }

        public bool VoidOrder { get; set; }

        public string Company { get; set; }

        public int OrderNum { get; set; }

        public int CustNum { get; set; }

        public string PONum { get; set; }

        public bool OrderHeld { get; set; }

        public string EntryPerson { get; set; }

        public string ShipToNum { get; set; }

        public  Nullable< DateTime> RequestDate { get; set; }

        public  Nullable< DateTime> OrderDate { get; set; }

        public string FOB { get; set; }

        public string ShipViaCode { get; set; }

        public string TermsCode { get; set; }

        public decimal DiscountPercent { get; set; }

        public int PrcConNum { get; set; }

        public int ShpConNum { get; set; }

        public string SalesRepList { get; set; }

        public string OrderComment { get; set; }

        public string ShipComment { get; set; }

        public string InvoiceComment { get; set; }

        public string PickListComment { get; set; }

        public decimal DepositBal { get; set; }

        public decimal DocDepositBal { get; set; }

        public  Nullable< DateTime> NeedByDate { get; set; }

        public bool CreditOverride { get; set; }

        public string CreditOverrideUserID { get; set; }

        public  Nullable< DateTime> CreditOverrideDate { get; set; }

        public string CreditOverrideTime { get; set; }

        public decimal CreditOverrideLimit { get; set; }

        public bool SndAlrtShp { get; set; }

        public decimal ExchangeRate { get; set; }

        public string CurrencyCode { get; set; }

        public bool LockRate { get; set; }

        public string CardMemberName { get; set; }

        public string CardNumber { get; set; }

        public string CardType { get; set; }

        public int ExpirationMonth { get; set; }

        public int ExpirationYear { get; set; }

        public string CardID { get; set; }

        public string CardmemberReference { get; set; }

        public string AllocPriorityCode { get; set; }

        public string ReservePriorityCode { get; set; }

        public bool ShipOrderComplete { get; set; }

        public bool WebOrder { get; set; }

        public string CCApprovalNum { get; set; }

        public bool EDIOrder { get; set; }

        public bool EDIAck { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        public string ExtCompany { get; set; }

        public string WebEntryPerson { get; set; }

        public bool AckEmailSent { get; set; }

        public bool ApplyOrderBasedDisc { get; set; }

        public bool AutoOrderBasedDisc { get; set; }

        public string EntryMethod { get; set; }

        public int HDCaseNum { get; set; }

        public bool CounterSale { get; set; }

        public bool CreateInvoice { get; set; }

        public bool CreatePackingSlip { get; set; }

        public bool LockQty { get; set; }

        public string ProcessCard { get; set; }

        public decimal CCAmount { get; set; }

        public decimal CCFreight { get; set; }

        public decimal CCTax { get; set; }

        public decimal CCTotal { get; set; }

        public decimal CCDocAmount { get; set; }

        public decimal CCDocFreight { get; set; }

        public decimal CCDocTax { get; set; }

        public decimal CCDocTotal { get; set; }

        public string CCStreetAddr { get; set; }

        public string CCZip { get; set; }

        public int BTCustNum { get; set; }

        public int BTConNum { get; set; }

        public decimal RepRate4 { get; set; }

        public decimal RepRate5 { get; set; }

        public int RepSplit1 { get; set; }

        public int RepSplit2 { get; set; }

        public int RepSplit3 { get; set; }

        public int RepSplit4 { get; set; }

        public int RepSplit5 { get; set; }

        public decimal RepRate1 { get; set; }

        public decimal RepRate2 { get; set; }

        public decimal RepRate3 { get; set; }

        public int OutboundSalesDocCtr { get; set; }

        public int OutboundShipDocsCtr { get; set; }

        public int DemandContractNum { get; set; }

        public  Nullable< DateTime> DoNotShipBeforeDate { get; set; }

        public bool ResDelivery { get; set; }

        public  Nullable< DateTime> DoNotShipAfterDate { get; set; }

        public bool SatDelivery { get; set; }

        public bool SatPickup { get; set; }

        public bool Hazmat { get; set; }

        public bool DocOnly { get; set; }

        public string RefNotes { get; set; }

        public bool ApplyChrg { get; set; }

        public decimal ChrgAmount { get; set; }

        public bool COD { get; set; }

        public bool CODFreight { get; set; }

        public bool CODCheck { get; set; }

        public decimal CODAmount { get; set; }

        public string GroundType { get; set; }

        public bool NotifyFlag { get; set; }

        public string NotifyEMail { get; set; }

        public bool DeclaredIns { get; set; }

        public decimal DeclaredAmt { get; set; }

        public  Nullable< DateTime> CancelAfterDate { get; set; }

        public bool DemandRejected { get; set; }

        public bool OverrideCarrier { get; set; }

        public bool OverrideService { get; set; }

        public bool CreditCardOrder { get; set; }

        public int DemandHeadSeq { get; set; }

        public string PayFlag { get; set; }

        public string PayAccount { get; set; }

        public string PayBTAddress1 { get; set; }

        public string PayBTAddress2 { get; set; }

        public string PayBTCity { get; set; }

        public string PayBTState { get; set; }

        public string PayBTZip { get; set; }

        public string PayBTCountry { get; set; }

        public bool DropShip { get; set; }

        public bool CommercialInvoice { get; set; }

        public bool ShipExprtDeclartn { get; set; }

        public bool CertOfOrigin { get; set; }

        public bool LetterOfInstr { get; set; }

        public string FFID { get; set; }

        public string FFAddress1 { get; set; }

        public string FFAddress2 { get; set; }

        public string FFCity { get; set; }

        public string FFState { get; set; }

        public string FFZip { get; set; }

        public string FFCountry { get; set; }

        public string FFContact { get; set; }

        public string FFCompName { get; set; }

        public string FFPhoneNum { get; set; }

        public bool IntrntlShip { get; set; }

        public string ChangedBy { get; set; }

        public  Nullable< DateTime> ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool AutoPrintReady { get; set; }

        public bool EDIReady { get; set; }

        public bool IndividualPackIDs { get; set; }

        public string FFAddress3 { get; set; }

        public int DeliveryConf { get; set; }

        public bool AddlHdlgFlag { get; set; }

        public bool NonStdPkg { get; set; }

        public bool ServSignature { get; set; }

        public bool ServAlert { get; set; }

        public bool ServHomeDel { get; set; }

        public string DeliveryType { get; set; }

        public  Nullable< DateTime> ServDeliveryDate { get; set; }

        public string ServInstruct { get; set; }

        public string ServRef1 { get; set; }

        public string ServRef2 { get; set; }

        public string ServRef3 { get; set; }

        public string ServRef4 { get; set; }

        public string ServRef5 { get; set; }

        public int FFCountryNum { get; set; }

        public string ServPhone { get; set; }

        public bool ServRelease { get; set; }

        public string ServAuthNum { get; set; }

        public string PayBTAddress3 { get; set; }

        public int PayBTCountryNum { get; set; }

        public string PayBTPhone { get; set; }

        public bool UPSQuantumView { get; set; }

        public string UPSQVShipFromName { get; set; }

        public string UPSQVMemo { get; set; }

        public bool ReadyToCalc { get; set; }

        public decimal TotalCharges { get; set; }

        public decimal TotalMisc { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalComm { get; set; }

        public decimal TotalAdvBill { get; set; }

        public int TotalLines { get; set; }

        public int TotalReleases { get; set; }

        public int TotalRelDates { get; set; }

        public decimal DocTotalCharges { get; set; }

        public decimal DocTotalMisc { get; set; }

        public decimal DocTotalDiscount { get; set; }

        public decimal DocTotalComm { get; set; }

        public decimal TotalTax { get; set; }

        public decimal DocTotalTax { get; set; }

        public decimal DocTotalAdvBill { get; set; }

        public decimal TotalShipped { get; set; }

        public decimal TotalInvoiced { get; set; }

        public int TotalCommLines { get; set; }

        public decimal SRCommAmt1 { get; set; }

        public decimal SRCommAmt2 { get; set; }

        public decimal SRCommAmt3 { get; set; }

        public decimal SRCommAmt4 { get; set; }

        public decimal SRCommAmt5 { get; set; }

        public decimal SRCommableAmt1 { get; set; }

        public decimal SRCommableAmt2 { get; set; }

        public decimal SRCommableAmt3 { get; set; }

        public decimal SRCommableAmt4 { get; set; }

        public decimal SRCommableAmt5 { get; set; }

        public decimal Rounding { get; set; }

        public decimal Rpt1DepositBal { get; set; }

        public decimal DocRounding { get; set; }

        public decimal Rpt2DepositBal { get; set; }

        public decimal Rpt3DepositBal { get; set; }

        public decimal Rpt1TotalCharges { get; set; }

        public decimal Rpt2TotalCharges { get; set; }

        public decimal Rpt3TotalCharges { get; set; }

        public decimal Rpt1TotalAdvBill { get; set; }

        public decimal Rpt2TotalAdvBill { get; set; }

        public decimal Rpt3TotalAdvBill { get; set; }

        public decimal Rpt1TotalMisc { get; set; }

        public decimal Rpt2TotalMisc { get; set; }

        public decimal Rpt3TotalMisc { get; set; }

        public decimal Rpt1TotalDiscount { get; set; }

        public decimal Rpt2TotalDiscount { get; set; }

        public decimal Rpt3TotalDiscount { get; set; }

        public decimal Rpt1TotalComm { get; set; }

        public decimal Rpt2TotalComm { get; set; }

        public decimal Rpt3TotalComm { get; set; }

        public decimal Rpt1TotalTax { get; set; }

        public decimal Rpt2TotalTax { get; set; }

        public decimal Rpt1Rounding { get; set; }

        public decimal Rpt2Rounding { get; set; }

        public decimal Rpt3Rounding { get; set; }

        public string RateGrpCode { get; set; }

        public decimal Rpt3TotalTax { get; set; }

        public decimal Rpt1CCAmount { get; set; }

        public decimal Rpt2CCAmount { get; set; }

        public decimal Rpt3CCAmount { get; set; }

        public decimal Rpt1CCFreight { get; set; }

        public decimal Rpt2CCFreight { get; set; }

        public decimal Rpt3CCFreight { get; set; }

        public decimal Rpt1CCTax { get; set; }

        public decimal Rpt2CCTax { get; set; }

        public decimal Rpt3CCTax { get; set; }

        public decimal Rpt1CCTotal { get; set; }

        public decimal Rpt2CCTotal { get; set; }

        public decimal Rpt3CCTotal { get; set; }

        public decimal OrderAmt { get; set; }

        public decimal DocOrderAmt { get; set; }

        public decimal Rpt1OrderAmt { get; set; }

        public decimal Rpt2OrderAmt { get; set; }

        public decimal Rpt3OrderAmt { get; set; }

        public  Nullable< DateTime> TaxPoint { get; set; }

        public  Nullable< DateTime> TaxRateDate { get; set; }

        public string TaxRegionCode { get; set; }

        public bool UseOTS { get; set; }

        public string OTSName { get; set; }

        public string OTSAddress1 { get; set; }

        public string OTSAddress2 { get; set; }

        public string OTSAddress3 { get; set; }

        public string OTSCity { get; set; }

        public string OTSState { get; set; }

        public string OTSZIP { get; set; }

        public string OTSResaleID { get; set; }

        public string OTSContact { get; set; }

        public string OTSFaxNum { get; set; }

        public string OTSPhoneNum { get; set; }

        public int OTSCountryNum { get; set; }

        public decimal TotalWHTax { get; set; }

        public decimal DocTotalWHTax { get; set; }

        public decimal Rpt1TotalWHTax { get; set; }

        public decimal Rpt2TotalWHTax { get; set; }

        public decimal Rpt3TotalWHTax { get; set; }

        public decimal TotalSATax { get; set; }

        public decimal DocTotalSATax { get; set; }

        public decimal Rpt1TotalSATax { get; set; }

        public decimal Rpt2TotalSATax { get; set; }

        public decimal Rpt3TotalSATax { get; set; }

        public string OTSSaveAs { get; set; }

        public string OTSSaveCustID { get; set; }

        public bool OTSCustSaved { get; set; }

        public int ShipToCustNum { get; set; }

        public string OrderStatus { get; set; }

        public bool HoldSetByDemand { get; set; }

        public bool InPrice { get; set; }

        public decimal InTotalCharges { get; set; }

        public decimal InTotalMisc { get; set; }

        public decimal InTotalDiscount { get; set; }

        public decimal DocInTotalCharges { get; set; }

        public decimal DocInTotalMisc { get; set; }

        public decimal DocInTotalDiscount { get; set; }

        public decimal Rpt1InTotalCharges { get; set; }

        public decimal Rpt2InTotalCharges { get; set; }

        public decimal Rpt3InTotalCharges { get; set; }

        public decimal Rpt1InTotalMisc { get; set; }

        public decimal Rpt2InTotalMisc { get; set; }

        public decimal Rpt3InTotalMisc { get; set; }

        public decimal Rpt1InTotalDiscount { get; set; }

        public decimal Rpt2InTotalDiscount { get; set; }

        public decimal Rpt3InTotalDiscount { get; set; }

        public string ARLOCID { get; set; }

        public string OurBank { get; set; }

        public bool ERSOrder { get; set; }

        public bool LOCHold { get; set; }

        public string PSCurrCode { get; set; }

        public string InvCurrCode { get; set; }

        public string LegalNumber { get; set; }

        public string TranDocTypeID { get; set; }

        public string XRefContractNum { get; set; }

        public  Nullable< DateTime> XRefContractDate { get; set; }

        public  Nullable< DateTime> DemandProcessDate { get; set; }

        public int DemandProcessTime { get; set; }

        public string LastScheduleNumber { get; set; }

        public string LastTCtrlNum { get; set; }

        public string LastBatchNum { get; set; }

        public string ECCOrderNum { get; set; }

        public string ECCPONum { get; set; }

        public string WIOrder { get; set; }

        public string WIApplication { get; set; }

        public string WIUsername { get; set; }

        public string WIUserID { get; set; }

        public bool WICreditCardorder { get; set; }

        public string OrderCSR { get; set; }

        public string UserChar1 { get; set; }

        public string UserChar2 { get; set; }

        public string UserChar3 { get; set; }

        public string UserChar4 { get; set; }

        public  Nullable< DateTime> UserDate1 { get; set; }

        public  Nullable< DateTime> UserDate2 { get; set; }

        public  Nullable< DateTime> UserDate3 { get; set; }

        public  Nullable< DateTime> UserDate4 { get; set; }

        public decimal UserDecimal1 { get; set; }

        public decimal UserDecimal2 { get; set; }

        public int UserInteger1 { get; set; }

        public int UserInteger2 { get; set; }

        public  Binary SysRevID { get; set; }

        public  Guid SysRowID { get; set; }

        public bool IsCSRSet { get; set; }

        public string ECCPaymentMethod { get; set; }

        public bool AGUseGoodDefaultMark { get; set; }

        public string OTSShipToNum { get; set; }

        public string ProFormaInvComment { get; set; }

        public string ccToken { get; set; }

        public bool InvcOrderCmp { get; set; }

        public bool ReprintSOAck { get; set; }

        public int CounterSOAck { get; set; }

        public string DispatchReason { get; set; }

        public string Plant { get; set; }

        public bool ReadyToFulfill { get; set; }

        public int ShipByTime { get; set; }


    }


    public class OrderDetailModel : CustomerModel
    {

        public bool VoidLine;

        public bool OpenLine;

        public string Company;

        public int OrderNum;

        public int OrderLine;

        public string LineType;

        public string PartNum;

        public string LineDesc;

        public string Reference;

        public string IUM;

        public string RevisionNum;

        public string POLine;

        public bool Commissionable;

        public decimal DiscountPercent;

        public decimal UnitPrice;

        public decimal DocUnitPrice;

        public decimal OrderQty;

        public decimal Discount;

        public decimal DocDiscount;

        public  Nullable< DateTime> RequestDate;

        public string ProdCode;

        public string XPartNum;

        public string XRevisionNum;

        public string PricePerCode;

        public string OrderComment;

        public string ShipComment;

        public string InvoiceComment;

        public string PickListComment;

        public string TaxCatID;

        public decimal AdvanceBillBal;

        public decimal DocAdvanceBillBal;

        public int QuoteNum;

        public int QuoteLine;

        public bool TMBilling;

        public string OrigWhyNoTax;

        public  Nullable< DateTime> NeedByDate;

        public int CustNum;

        public bool Rework;

        public int RMANum;

        public int RMALine;

        public string ProjectID;

        public int ContractNum;

        public string ContractCode;

        public string BasePartNum;

        public bool Warranty;

        public string WarrantyCode;

        public int MaterialDuration;

        public int LaborDuration;

        public int MiscDuration;

        public string MaterialMod;

        public string LaborMod;

        public string WarrantyComment;

        public bool Onsite;

        public bool MatCovered;

        public bool LabCovered;

        public bool MiscCovered;

        public string SalesUM;

        public decimal SellingFactor;

        public decimal SellingQuantity;

        public string SalesCatID;

        public bool ShipLineComplete;

        public decimal CumeQty;

        public  Nullable< DateTime> CumeDate;

        public string MktgCampaignID;

        public int MktgEvntSeq;

        public bool LockQty;

        public bool Linked;

        public int ICPONum;

        public int ICPOLine;

        public string ExtCompany;

        public  Nullable< DateTime> LastConfigDate;

        public int LastConfigTime;

        public string LastConfigUserID;

        public decimal ConfigUnitPrice;

        public decimal ConfigBaseUnitPrice;

        public string PriceListCode;

        public string BreakListCode;

        public decimal PricingQty;

        public bool LockPrice;

        public decimal ListPrice;

        public decimal DocListPrice;

        public decimal OrdBasedPrice;

        public decimal DocOrdBasedPrice;

        public string PriceGroupCode;

        public bool OverridePriceList;

        public string BaseRevisionNum;

        public decimal PricingValue;

        public decimal DisplaySeq;

        public int KitParentLine;

        public bool KitAllowUpdate;

        public bool KitShipComplete;

        public bool KitBackFlush;

        public bool KitPrintCompsPS;

        public bool KitPrintCompsInv;

        public string KitPricing;

        public decimal KitQtyPer;

        public string SellingFactorDirection;

        public decimal RepRate1;

        public decimal RepRate2;

        public decimal RepRate3;

        public decimal RepRate4;

        public decimal RepRate5;

        public int RepSplit1;

        public int RepSplit2;

        public int RepSplit3;

        public int RepSplit4;

        public int RepSplit5;

        public int DemandContractLine;

        public bool CreateNewJob;

        public  Nullable< DateTime> DoNotShipBeforeDate;

        public bool GetDtls;

        public  Nullable< DateTime> DoNotShipAfterDate;

        public bool SchedJob;

        public bool RelJob;

        public bool EnableCreateNewJob;

        public bool EnableGetDtls;

        public bool EnableSchedJob;

        public bool EnableRelJob;

        public string CounterSaleWarehouse;

        public string CounterSaleBinNum;

        public string CounterSaleLotNum;

        public string CounterSaleDimCode;

        public bool DemandDtlRejected;

        public string KitFlag;

        public bool KitsLoaded;

        public int DemandContractNum;

        public int DemandHeadSeq;

        public int DemandDtlSeq;

        public string ChangedBy;

        public  Nullable< DateTime> ChangeDate;

        public int ChangeTime;

        public bool ReverseCharge;

        public int TotalReleases;

        public decimal Rpt1UnitPrice;

        public decimal Rpt2UnitPrice;

        public decimal Rpt3UnitPrice;

        public decimal Rpt1Discount;

        public decimal Rpt2Discount;

        public decimal Rpt3Discount;

        public decimal Rpt1AdvanceBillBal;

        public decimal Rpt2AdvanceBillBal;

        public decimal Rpt3AdvanceBillBal;

        public decimal Rpt1ListPrice;

        public decimal Rpt2ListPrice;

        public decimal Rpt3ListPrice;

        public decimal Rpt1OrdBasedPrice;

        public decimal Rpt2OrdBasedPrice;

        public decimal Rpt3OrdBasedPrice;

        public decimal ExtPriceDtl;

        public decimal DocExtPriceDtl;

        public decimal Rpt1ExtPriceDtl;

        public decimal Rpt2ExtPriceDtl;

        public decimal Rpt3ExtPriceDtl;

        public string LineStatus;

        public decimal InUnitPrice;

        public decimal DocInUnitPrice;

        public decimal InDiscount;

        public decimal DocInDiscount;

        public decimal InListPrice;

        public decimal DocInListPrice;

        public decimal InOrdBasedPrice;

        public decimal DocInOrdBasedPrice;

        public decimal Rpt1InUnitPrice;

        public decimal Rpt2InUnitPrice;

        public decimal Rpt3InUnitPrice;

        public decimal Rpt1InDiscount;

        public decimal Rpt2InDiscount;

        public decimal Rpt3InDiscount;

        public decimal Rpt1InListPrice;

        public decimal Rpt2InListPrice;

        public decimal Rpt3InListPrice;

        public decimal Rpt1InOrdBasedPrice;

        public decimal Rpt2InOrdBasedPrice;

        public decimal Rpt3InOrdBasedPrice;

        public decimal InExtPriceDtl;

        public decimal DocInExtPriceDtl;

        public decimal Rpt1InExtPriceDtl;

        public decimal Rpt2InExtPriceDtl;

        public decimal Rpt3InExtPriceDtl;

        public decimal OldOurOpenQty;

        public decimal OldSellingOpenQty;

        public decimal OldOpenValue;

        public string OldProdCode;

        public decimal PrevSellQty;

        public string PrevPartNum;

        public string PrevXPartNum;

        public int KitCompOrigSeq;

        public string KitCompOrigPart;

        public bool SmartStringProcessed;

        public string SmartString;

        public int RenewalNbr;

        public string DiscBreakListCode;

        public decimal DiscListPrice;

        public bool LockDisc;

        public bool OverrideDiscPriceList;

        public int GroupSeq;

        public string ECCOrderNum;

        public int ECCOrderLine;

        public bool DupOnJobCrt;

        public decimal UndersPct;

        public decimal Overs;

        public decimal Unders;

        public decimal OversUnitPrice;

        public string PlanUserID;

        public string PlanGUID;

        public string MOMsourceType;

        public string MOMsourceEst;

        public string DefaultOversPricing;

        public string ECCPlant;

        public string ECCQuoteNum;

        public int ECCQuoteLine;

        public  Binary SysRevID;

        public  Guid SysRowID;

        public string MfgJobType;

        public string ProFormaInvComment;

        public bool CreateJob;

        public string ContractID;

        public bool LinkToContract;

        public decimal DocInAdvanceBillBal;

        public decimal InAdvanceBillBal;

        public decimal Rpt1InAdvanceBillBal;

        public decimal Rpt2InAdvanceBillBal;

        public decimal Rpt3InAdvanceBillBal;

        public bool PCLinkRemoved;


    }

    public class CustomerModel
    {
        public string Company;

        public string CustID;

        public int CustNum;

        public string Name;

        public string Address1;

        public string Address2;

        public string Address3;

        public string City;

        public string State;

        public string Zip;

        public string Country;

        public string ResaleID;

        public string SalesRepCode;

        public string TerritoryID;

        public string ShipToNum;

        public string TermsCode;

        public string ShipViaCode;

        public bool PrintStatements;

        public bool PrintLabels;

        public bool PrintAck;

        public bool FinCharges;

        public bool CreditHold;

        public string GroupCode;

        public decimal DiscountPercent;

        public int PrimPCon;

        public int PrimBCon;

        public int PrimSCon;

        public string Comment;

        public  Nullable< DateTime> EstDate;

        public string FaxNum;

        public string PhoneNum;

        public string TaxExempt;

        public string MarkUpID;

        public int BillDay;

        public bool OneInvPerPS;

        public string DefaultFOB;

        public bool CreditIncludeOrders;

        public  Nullable< DateTime> CreditReviewDate;

        public  Nullable< DateTime> CreditHoldDate;

        public string CreditHoldSource;

        public string CreditClearUserID;

        public  Nullable< DateTime> CreditClearDate;

        public string CreditClearTime;

        public string EDICode;

        public string CurrencyCode;

        public int CountryNum;

        public string LangNameID;

        public string BorderCrossing;

        public string FormatStr;

        public string BTName;

        public string BTAddress1;

        public string BTAddress2;

        public string BTAddress3;

        public string BTCity;

        public string BTState;

        public string BTZip;

        public int BTCountryNum;

        public string BTCountry;

        public string BTPhoneNum;

        public string BTFaxNum;

        public string BTFormatStr;

        public int ParentCustNum;

        public string TaxRegionCode;

        public bool ICCust;

        public int ContBillDay;

        public string EMailAddress;

        public string ShippingQualifier;

        public string AllocPriorityCode;

        public string ReservePriorityCode;

        public int LinkPortNum;

        public bool WebCustomer;

        public string CustomerType;

        public bool NoContact;

        public bool TerritoryLock;

        public string CustURL;

        public string PendingTerritoryID;

        public string ExtID;

        public bool ConsolidateSO;

        public string BillFrequency;

        public bool CreditIncludePI;

        public bool GlobalCust;

        public bool ICTrader;

        public string TaxAuthorityCode;

        public bool ExternalDeliveryNote;

        public bool GlobalCredIncOrd;

        public bool GlobalCredIncPI;

        public string GlobalCurrencyCode;

        public string ExternalID;

        public string GlobalCreditHold;

        public bool GlobalLock;

        public bool CheckDuplicatePO;

        public decimal CreditLimit;

        public decimal CustPILimit;

        public decimal GlobalCreditLimit;

        public decimal GlobalPILimit;

        public decimal DocGlobalCreditLimit;

        public decimal DocGlobalPILimit;

        public bool RfqAttachAllow;

        public string DiscountQualifier;

        public bool AllowAltBillTo;

        public int DemandDeliveryDays;

        public string DemandDateType;

        public int DemandAddLeadTime;

        public string DemandAddAction;

        public int DemandChangeLeadTime;

        public string DemandChangeAction;

        public int DemandCancelLeadTime;

        public string DemandCancelAction;

        public int DemandNewLineLeadTime;

        public string DemandNewLineAction;

        public int DemandQtyChangeLeadTime;

        public string DemandQtyChangeAction;

        public int DemandChangeDateLeadTime;

        public string DemandChangeDateAction;

        public string TradingPartnerName;

        public bool ResDelivery;

        public bool SatDelivery;

        public bool SatPickup;

        public bool Hazmat;

        public bool DocOnly;

        public string RefNotes;

        public bool ApplyChrg;

        public decimal ChrgAmount;

        public bool COD;

        public bool CODFreight;

        public bool CODCheck;

        public decimal CODAmount;

        public string GroundType;

        public bool NotifyFlag;

        public string NotifyEMail;

        public bool DeclaredIns;

        public decimal DeclaredAmt;

        public int PeriodicityCode;

        public bool ServSignature;

        public bool ServAlert;

        public bool ServHomeDel;

        public string DeliveryType;

        public  Nullable< DateTime> ServDeliveryDate;

        public string ServPhone;

        public string ServInstruct;

        public bool ServRelease;

        public string ServAuthNum;

        public string ServRef1;

        public string ServRef2;

        public string ServRef3;

        public string ServRef4;

        public string ServRef5;

        public int EarlyBuffer;

        public int LateBuffer;

        public bool DemandUnitPriceDiff;

        public string DemandUnitPriceDiffAction;

        public bool ExcFromVal;

        public bool AddressVal;

        public int RebateVendorNum;

        public string RebateForm;

        public bool CreditCardOrder;

        public bool DemandCheckForPart;

        public string DemandCheckForPartAction;

        public string ChangedBy;

        public  Nullable< DateTime> ChangeDate;

        public int ChangeTime;

        public string ChargeCode;

        public bool IndividualPackIDs;

        public bool IntrntlShip;

        public bool CertOfOrigin;

        public bool CommercialInvoice;

        public bool ShipExprtDeclartn;

        public bool LetterOfInstr;

        public string FFID;

        public string FFCompName;

        public string FFAddress1;

        public string FFAddress2;

        public string FFAddress3;

        public string FFCity;

        public string FFState;

        public string FFZip;

        public string FFCountry;

        public int FFCountryNum;

        public string FFPhoneNum;

        public bool NonStdPkg;

        public int DeliveryConf;

        public bool AddlHdlgFlag;

        public bool UPSQuantumView;

        public string UPSQVShipFromName;

        public string UPSQVMemo;

        public string UPSQVEmailType;

        public string FFContact;

        public bool ETCAddrChg;

        public int TaxRoundRule;

        public string TaxMethod;

        public bool ValidPayer;

        public bool ValidSoldTo;

        public bool ValidShipTo;

        public bool OverrideRlsClass;

        public bool AcrossNatAcc;

        public bool NAParentCreditIsUsed;

        public bool NACreditIsShare;

        public string NACreditPreferenceList;

        public decimal NAParentCreditPrc;

        public decimal NACreditSharedPrc;

        public bool AllowOTS;

        public bool ThirdPLCust;

        public string ManagedVendID;

        public int ManagedVendNum;

        public string NARlsClassCode;

        public bool DirectDebiting;

        public string ReminderCode;

        public bool GlbNAParentCreditIsUsed;

        public bool GlbNACreditIsShare;

        public decimal GlbNAParentCreditPrc;

        public decimal GlbNACreditSharedPrc;

        public bool AllowShipTo3;

        public string OTSSaveAs;

        public string CustPartOpts;

        public bool HasBank;

        public int PMUID;

        public bool DemandCheckForRev;

        public bool OrderHoldForReview;

        public string DemandCheckForRevAction;

        public string ShipToTerrList;

        public string AcctRefNumber;

        public string ARInvoiceITCode;

        public string CreditMemoITCode;

        public string MiscCashRecITCode;

        public string LegalName;

        public string ARInvoiceAdjITCode;

        public string TaxRegReason;

        public bool InvPerPackLine;

        public string OrgRegCode;

        public bool DemandCloseRejSkd;

        public string OurBankCode;

        public bool DemandCloseNoMatch;

        public bool DmdCheckPartialShip;

        public string DmdCheckShipAction;

        public bool DemandCheckCUMM;

        public string DemandCheckCUMMAction;

        public string DemandPricing;

        public decimal PriceTolerance;

        public string PreferredBank;

        public bool CheckDateCapPromise;

        public bool CheckConfirmCapPromise;

        public bool CheckUpdateCapPromise;

        public string DemandCapPromiseDate;

        public string DemandCapPromiseAction;

        public string DemandCapPromiseUpdate;

        public bool PeriodicBilling;

        public string DueDateCriteria;

        public int PBTerms;

        public bool ERSOrder;

        public bool DemandSplitSched;

        public bool OTSmartString;

        public bool DeferredRev;

        public string RACode;

        public bool DemandCheckConfig;

        public string DemandCheckCfgAction;

        public bool AllowAsAltRemitTo;

        public string FederalID;

        public string WIApplication;

        public string WICustomer;

        public bool WIShippingCosts;

        public bool LOQBookPCFinishing;

        public bool LOQBookPCPaper;

        public bool LOQBookPCPress;

        public bool LOQBookPCPlates;

        public bool Variations;

        public decimal OversPct;

        public decimal UndersPct;

        public string DefaultLOQstyle;

        public string DefaultOrderAcknowledgement;

        public string DefaultPackSlip;

        public string DefaultOversPricing;

        public string LOQPrepressStyle;

        public string CSR;

        public bool LOQBookCaFinishing;

        public bool LOQBookCapaper;

        public bool LOQBookCaPress;

        public bool LOQBookCatPlates;

        public bool LOQVariations;

        public string DefaultInvoicestyle;

        public string AEPLOQType;

        public string BusinessCust;

        public  Binary SysRevID;

        public  Guid SysRowID;

        public string THBranchID;

        public string CustPricingSchema;

        public string ParamCode;

        public string AGAFIPResponsibilityCode;

        public string AGBillToProvinceCode;

        public string AGGrossIncomeTaxID;

        public string AGIDDocTypeCode;

        public string AGIDDocumentNumber;

        public string AGProvinceCode;

        public bool AGUseGoodDefaultMark;

        public bool Collections;

        public  Nullable< DateTime> CollectionsDate;

        public  Nullable< DateTime> DateCollectionPosted;

        public string MXMunicipio;

        public string PEIdentityDocType;

        public string PEDocumentID;

        public bool PEGoodsContributor;

        public bool PEWithholdAgent;

        public bool PECollectionAgent;

        public bool PENotFound;

        public bool PENoAddress;

        public string EntityUseCode;

        public bool InvcOrderCmpDflt;

        public bool EInvoice;

        public string RegistrationCode;

        public string EAddress;

        public bool DemandCheckForRunOutPart;

        public string DemandCheckForRunOutPartAction;

        public string EInvCompanyIDAttr;

        public string INCSTNumber;

        public string INPANNumber;

        public string COOneTimeID;

        public bool COIsOneTimeCust;

        public string DEOrgType;

        public string PEGuaranteeName;

        public string PEGuaranteeAddress1;

        public string PEGuaranteeAddress2;

        public string PEGuaranteeAddress3;

        public string PEGuaranteeCity;

        public string PEGuaranteeState;

        public string PEGuaranteeZip;

        public string PEGuaranteeCountry;

        public string PEGuaranteePhoneNum;

        public string PEGuaranteeTaxID;

        public string OurSupplierCode;

        public string ECCType;

        public string MYIndustryCode;

        public bool SyncToExternalCRM;

        public string ExternalCRMCustomerID;

        public string ExternalCRMCustomerType;

        public  Nullable< DateTime> ExternalCRMLastSync;

        public bool ExternalCRMSyncRequired;

        public string Ownership;

        public string Industry;

        public decimal AnnualRevenue;

        public int NumberOfEmployees;

        public string TickerLocation;

        public string TickerSymbol;

        public string Rating;
    }

    public class CustomerUDModel {
        public bool notifyviaemailc{get;set;}

        public bool notifyviaprintc{get;set;}

        public string storenumberc{get;set;}

        public bool ApplyChrOverridec{get;set;}

        public bool DropShipc{get;set;}

        public bool Inactivec{get;set;}

        public bool InvoiceSummaryc{get;set;}

        public string ARNotesc{get;set;}

        public bool BadDebtc{get;set;}

        public bool IsSupressOrderNotificationc{get;set;}

        public bool YextActivec{get;set;}

        public bool YextAutoRenewc{get;set;}

        public string YextCustomerNumberc{get;set;}

        public decimal YextFeec{get;set;}

        public  Nullable< DateTime> YextRenewDatec{get;set;}

        public string YextSSOTokenc{get;set;}

        public  Nullable< DateTime> YextStartDatec{get;set;}

        public bool SendShippingNotificationsc{get;set;}
    }

    public class CustomerGroupModel: CustomerGroupUDModel
    {
        public string Company { get; set; }

        public string GroupCode { get; set; }

        public string GroupDesc { get; set; }

        public string SalesCatID { get; set; }

        public bool GlobalCustGrup { get; set; }

        public bool GlobalLock { get; set; }
        public object ForeignSysRowID { get; internal set; }

        public System.Data.Linq.Binary SysRevID;

        public System.Guid SysRowID;

    }

    public class CustomerGroupUDModel
    {
        public bool allowBillToEditc{ get; set; }

        public bool allowShipToEditc{ get; set; }

        public string eCommURLc{ get; set; }

        public string parentCustomerGroupc{ get; set; }

        public bool AllowAutomaticApprovalc{ get; set; }

        public int AutomaticApprovalLapseInMinsc{ get; set; }

        public int DotitNotificationLapseInMinsc{ get; set; }

        public string EmailDotitNotificationsc{ get; set; }

        public bool IsAllPartsc{ get; set; }

        public bool IsCompanyWideEscalationc{ get; set; }

        public bool IsRequisitionCustomerc{ get; set; }

        public int RequisitionNotificationLapseInMinsc{ get; set; }

        public int SeniorNotificationLapseInMinsc{ get; set; }

        public bool IsBrandFulfillmentc{ get; set; }
    }

    public class VebdorBankModel
    {
        public string Company { get; set; }

        public int VendorNum { get; set; }

        public string BankID { get; set; }

        public string BankName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public int CountryNum { get; set; }

        public string BankAcctNumber { get; set; }

        public string NameOnAccount { get; set; }

        public string SwiftNum { get; set; }

        public int PMUID { get; set; }

        public string BankBranchCode { get; set; }

        public string IBANCode { get; set; }

        public string SECreditTransNum { get; set; }

        public string LegalName { get; set; }

        public string CorrespAccount { get; set; }

        public string LocalBIC { get; set; }

        public string BankPersonCode { get; set; }

        public string VendAccountType { get; set; }

        public string CardCode { get; set; }

        public string BankGiroAcctNbr { get; set; }

        public string BankRefCode { get; set; }

        public bool AllowAsAltRemitToBank { get; set; }

        public string DFIIdentification { get; set; }

        public  Binary SysRevID { get; set; }

        public  Guid SysRowID { get; set; }

        public string CHDTAID { get; set; }

        public string CHISRPartyID { get; set; }

        public string FeeOwnership { get; set; }

        public string POBankAcctNum { get; set; }

        public string BankCustNum { get; set; }

        public int BankCustNumberStartPos { get; set; }

        public int BankCustNumberLen { get; set; }

        public string BAddress1 { get; set; }

        public string BAddress2 { get; set; }

        public string BAddress3 { get; set; }

        public string BankCharges { get; set; }

        public string BankCnstSymbol { get; set; }

        public string BankSpecSymbol { get; set; }

        public string BankType { get; set; }

        public string BCity { get; set; }

        public int BCountryNum { get; set; }

        public string BPostalCode { get; set; }

        public string BState { get; set; }

        public string NOChequeCode { get; set; }

        public string NOFeeCostCode { get; set; }

        public string ReceiverName { get; set; }

        public string ReceivingBankName { get; set; }

        public string ReceivingBankNum { get; set; }

        public string ReceivingBranchName { get; set; }

        public string ReceivingBranchNum { get; set; }

        public string SEBankFeeCostOwner { get; set; }

        public bool PEDetractionsNBA { get; set; }

        public string MXSATCode { get; set; }

        public string MXSATNameShort { get; set; }

        public string MXSATNameFull { get; set; }

        public string DKCreditorNum { get; set; }

    }

    public class YextHeaderModel
    {

        public int YEXTID{get;set;}

        public bool ISACTIVE{get;set;}

        public bool ISAUTORENEW{get;set;}

        public decimal NEXTFEE{get;set;}

        public  DateTime RENEWALDATE{get;set;}

        public  DateTime STARTDATE{get;set;}

        public string YEXTSSOTOKEN{get;set;}

        public string YEXTCUSTNUM{get;set;}

        public int EPICORCUSTNUM{get;set;}

        public  Nullable<int> MAGENTOCUSTNUM{get;set;}

        public string MAGENTOEMAIL{get;set;}

        public  DateTime CREATEDATE{get;set;}

        public string CREATEDBY{get;set;}

        public  DateTime MODIFIEDDATE{get;set;}

        public string MODIFIEDBY{get;set;}

        public List<YextDetailModel> YEXTDETAILs{get;set;}

    }
    public class YextDetailModel
    {
        public int EPICORORDERNUM{get;set;}

        public int YEXTID{get;set;}

        public string PARTNUM{get;set;}

        public int ORDERQTY{get;set;}

        public  DateTime ORDERDATE{get;set;}

        public bool ISONLINE{get;set;}

        public decimal PRICE{get;set;}

        public string ENTRYPERSON{get;set;}

    }


    public class ShipHeadModel : ShipHeadHDModel
    {
        public string Company{ get; set; }

        public int PackNum{ get; set; }

        public System.Nullable<System.DateTime> ShipDate{ get; set; }

        public string ShipViaCode{ get; set; }

        public string ShipPerson{ get; set; }

        public string EntryPerson{ get; set; }

        public string ShipLog{ get; set; }

        public string LabelComment{ get; set; }

        public string ShipComment{ get; set; }

        public bool Invoiced{ get; set; }

        public string ShipToNum{ get; set; }

        public bool ReadyToInvoice{ get; set; }

        public int CustNum{ get; set; }

        public string Plant{ get; set; }

        public string TrackingNumber{ get; set; }

        public string LegalNumber{ get; set; }

        public bool Voided{ get; set; }

        public bool ExternalDeliveryNote{ get; set; }

        public string ExternalID{ get; set; }

        public bool ICReceived{ get; set; }

        public string XRefPackNum{ get; set; }

        public int BTCustNum{ get; set; }

        public int BTConNum{ get; set; }

        public string ShipStatus{ get; set; }

        public string ShipGroup{ get; set; }

        public string PkgCode{ get; set; }

        public string PkgClass{ get; set; }

        public decimal Weight{ get; set; }

        public bool ResDelivery{ get; set; }

        public bool SatDelivery{ get; set; }

        public bool SatPickup{ get; set; }

        public bool VerbalConf{ get; set; }

        public bool Hazmat{ get; set; }

        public bool DocOnly{ get; set; }

        public string RefNotes{ get; set; }

        public bool ApplyChrg{ get; set; }

        public decimal ChrgAmount{ get; set; }

        public bool COD{ get; set; }

        public bool CODFreight{ get; set; }

        public bool CODCheck{ get; set; }

        public decimal CODAmount{ get; set; }

        public string GroundType{ get; set; }

        public bool NotifyFlag{ get; set; }

        public string NotifyEMail{ get; set; }

        public bool DeclaredIns{ get; set; }

        public decimal DeclaredAmt{ get; set; }

        public string MFTransNum{ get; set; }

        public string MFCallTag{ get; set; }

        public string MFPickupNum{ get; set; }

        public decimal MFDiscFreight{ get; set; }

        public string MFTemplate{ get; set; }

        public bool MFUse3B{ get; set; }

        public string MF3BAccount{ get; set; }

        public decimal MFDimWeight{ get; set; }

        public string MFZone{ get; set; }

        public decimal MFFreightAmt{ get; set; }

        public decimal MFOtherAmt{ get; set; }

        public bool MFOversized{ get; set; }

        public bool ServSatDelivery{ get; set; }

        public bool ServSatPickup{ get; set; }

        public bool ServSignature{ get; set; }

        public bool ServAlert{ get; set; }

        public bool ServPOD{ get; set; }

        public bool ServAOD{ get; set; }

        public bool ServHomeDel{ get; set; }

        public string DeliveryType{ get; set; }

        public System.Nullable<System.DateTime> ServDeliveryDate{ get; set; }

        public string ServPhone{ get; set; }

        public string ServInstruct{ get; set; }

        public bool ServRelease{ get; set; }

        public string ServAuthNum{ get; set; }

        public string ServRef1{ get; set; }

        public string ServRef2{ get; set; }

        public string ServRef3{ get; set; }

        public string ServRef4{ get; set; }

        public string ServRef5{ get; set; }

        public int BOLNum{ get; set; }

        public int BOLLine{ get; set; }

        public bool CommercialInvoice{ get; set; }

        public bool ShipExprtDeclartn{ get; set; }

        public bool CertOfOrigin{ get; set; }

        public bool LetterOfInstr{ get; set; }

        public bool HazardousShipment{ get; set; }

        public bool IntrntlShip{ get; set; }

        public string PayFlag{ get; set; }

        public string PayAccount{ get; set; }

        public string PayBTAddress1{ get; set; }

        public string PayBTAddress2{ get; set; }

        public string PayBTCity{ get; set; }

        public string PayBTState{ get; set; }

        public string PayBTZip{ get; set; }

        public string PayBTCountry{ get; set; }

        public string FFAddress1{ get; set; }

        public string FFAddress2{ get; set; }

        public string FFCity{ get; set; }

        public string FFState{ get; set; }

        public string FFZip{ get; set; }

        public string FFCountry{ get; set; }

        public string FFContact{ get; set; }

        public string FFCompName{ get; set; }

        public string FFPhoneNum{ get; set; }

        public string ChangedBy{ get; set; }

        public System.Nullable<System.DateTime> ChangeDate{ get; set; }

        public int ChangeTime{ get; set; }

        public string FFID{ get; set; }

        public bool IndividualPackIDs{ get; set; }

        public string FFAddress3{ get; set; }

        public int DeliveryConf{ get; set; }

        public bool AddlHdlgFlag{ get; set; }

        public bool NonStdPkg{ get; set; }

        public int FFCountryNum{ get; set; }

        public string PayBTAddress3{ get; set; }

        public int PayBTCountryNum{ get; set; }

        public string PayBTPhone{ get; set; }

        public string WayBillNbr{ get; set; }

        public string FreightedShipViaCode{ get; set; }

        public bool UPSQuantumView{ get; set; }

        public string UPSQVShipFromName{ get; set; }

        public string UPSQVMemo{ get; set; }

        public decimal PkgLength{ get; set; }

        public decimal PkgWidth{ get; set; }

        public decimal PkgHeight{ get; set; }

        public bool EDIReady{ get; set; }

        public bool PhantomPack{ get; set; }

        public int ReplicatedFrom{ get; set; }

        public string ReplicatedStat{ get; set; }

        public string PkgSizeUOM{ get; set; }

        public string WeightUOM{ get; set; }

        public bool UseOTS{ get; set; }

        public string TranDocTypeID{ get; set; }

        public bool DocumentPrinted{ get; set; }

        public int OTSOrderNum{ get; set; }

        public bool TaxCalculated{ get; set; }

        public System.Nullable<System.DateTime> TaxCalcDate{ get; set; }

        public string CurrencyCode{ get; set; }

        public decimal Rounding{ get; set; }

        public decimal Rpt1Rounding{ get; set; }

        public decimal Rpt2Rounding{ get; set; }

        public decimal Rpt3Rounding{ get; set; }

        public decimal DocRounding{ get; set; }

        public decimal Rpt1TotalTax{ get; set; }

        public decimal Rpt2TotalTax{ get; set; }

        public decimal Rpt3TotalTax{ get; set; }

        public decimal OrderAmt{ get; set; }

        public decimal DocOrderAmt{ get; set; }

        public decimal Rpt1OrderAmt{ get; set; }

        public decimal Rpt2OrderAmt{ get; set; }

        public decimal Rpt3OrderAmt{ get; set; }

        public string TaxRegionCode{ get; set; }

        public decimal TotalWHTax{ get; set; }

        public decimal DocTotalWHTax{ get; set; }

        public decimal Rpt1TotalWHTax{ get; set; }

        public decimal Rpt2TotalWHTax{ get; set; }

        public decimal Rpt3TotalWHTax{ get; set; }

        public decimal TotalSATax{ get; set; }

        public decimal DocTotalSATax{ get; set; }

        public decimal Rpt1TotalSATax{ get; set; }

        public decimal Rpt2TotalSATax{ get; set; }

        public decimal Rpt3TotalSATax{ get; set; }

        public decimal TotalTax{ get; set; }

        public decimal DocTotalTax{ get; set; }

        public decimal TotalDiscount{ get; set; }

        public decimal Rpt1TotalDiscount{ get; set; }

        public decimal Rpt2TotalDiscount{ get; set; }

        public decimal Rpt3TotalDiscount{ get; set; }

        public decimal DocTotalDiscount{ get; set; }

        public int ShipToCustNum{ get; set; }

        public string DeviceUOM{ get; set; }

        public string ManifestSizeUOM{ get; set; }

        public string ManifestWtUOM{ get; set; }

        public decimal ManifestWeight{ get; set; }

        public decimal ManifestLength{ get; set; }

        public decimal ManifestWidth{ get; set; }

        public decimal ManifestHeight{ get; set; }

        public string RateGrpCode{ get; set; }

        public bool InPrice{ get; set; }

        public bool PBHoldNoInv{ get; set; }

        public int Obs10PkgNum{ get; set; }

        public decimal ReconcileQty{ get; set; }

        public string ScheduleNumber{ get; set; }

        public int CounterASN{ get; set; }

        public string OurBank{ get; set; }

        public bool ERSOrder{ get; set; }

        public bool AutoPrintReady{ get; set; }

        public bool ShipOvers{ get; set; }

        public bool WIPackSlipCreated{ get; set; }

        public System.Data.Linq.Binary SysRevID{ get; set; }

        public System.Guid SysRowID{ get; set; }

        public string AGAuthorizationCode{ get; set; }

        public System.Nullable<System.DateTime> AGAuthorizationDate{ get; set; }

        public string AGCarrierCUIT{ get; set; }

        public bool AGCOTMark{ get; set; }

        public string AGDocumentLetter{ get; set; }

        public string AGInvoicingPoint{ get; set; }

        public string AGLegalNumber{ get; set; }

        public string AGPrintingControlType{ get; set; }

        public string AGTrackLicense{ get; set; }

        public string DispatchReason{ get; set; }

        public string AGShippingWay{ get; set; }

        public string OurSupplierCode{ get; set; }

        public System.Nullable<System.DateTime> ASNPrintedDate{ get; set; }


    }
    public class ShipToModel 
    {
        public string Company{ get; set; }

        public int CustNum{ get; set; }

        public string ShipToNum{ get; set; }

        public string Name{ get; set; }

        public string Address1{ get; set; }

        public string Address2{ get; set; }

        public string Address3{ get; set; }

        public string City{ get; set; }

        public string State{ get; set; }

        public string ZIP{ get; set; }

        public string Country{ get; set; }

        public string ResaleID{ get; set; }

        public string SalesRepCode{ get; set; }

        public string TerritoryID{ get; set; }

        public string ShipViaCode{ get; set; }

        public int PrimSCon{ get; set; }

        public string FaxNum{ get; set; }

        public string PhoneNum{ get; set; }

        public string TaxExempt{ get; set; }

        public string EDIShipNum{ get; set; }

        public int CountryNum{ get; set; }

        public string LangNameID{ get; set; }

        public string BorderCrossing{ get; set; }

        public string FormatStr{ get; set; }

        public string TaxRegionCode{ get; set; }

        public string EMailAddress{ get; set; }

        public string TerritorySelect{ get; set; }

        public string PendingTerritoryID{ get; set; }

        public bool CreatedByEDI{ get; set; }

        public string ExternalID{ get; set; }

        public string TaxAuthorityCode{ get; set; }

        public bool GlobalLock{ get; set; }

        public string EDICode{ get; set; }

        public int DemandDeliveryDays{ get; set; }

        public string DemandDateType{ get; set; }

        public int DemandAddLeadTime{ get; set; }

        public string DemandAddAction{ get; set; }

        public int DemandChangeLeadTime{ get; set; }

        public string DemandChangeAction{ get; set; }

        public int DemandCancelLeadTime{ get; set; }

        public string DemandCancelAction{ get; set; }

        public int DemandNewLineLeadTime{ get; set; }

        public string DemandNewLineAction{ get; set; }

        public int DemandQtyChangeLeadTime{ get; set; }

        public string DemandQtyChangeAction{ get; set; }

        public int DemandChangeDateLeadTime{ get; set; }

        public string DemandChangeDateAction{ get; set; }

        public string TradingPartnerName{ get; set; }

        public bool ResDelivery{ get; set; }

        public bool SatDelivery{ get; set; }

        public bool SatPickup{ get; set; }

        public bool Hazmat{ get; set; }

        public bool DocOnly{ get; set; }

        public string RefNotes{ get; set; }

        public bool ApplyChrg{ get; set; }

        public decimal ChrgAmount{ get; set; }

        public bool COD{ get; set; }

        public bool CODFreight{ get; set; }

        public bool CODCheck{ get; set; }

        public decimal CODAmount{ get; set; }

        public string GroundType{ get; set; }

        public bool NotifyFlag{ get; set; }

        public string NotifyEMail{ get; set; }

        public bool DeclaredIns{ get; set; }

        public decimal DeclaredAmt{ get; set; }

        public int PeriodicityCode{ get; set; }

        public bool ServSignature{ get; set; }

        public bool ServAlert{ get; set; }

        public bool ServHomeDel{ get; set; }

        public string DeliveryType{ get; set; }

        public System.Nullable<System.DateTime> ServDeliveryDate{ get; set; }

        public string ServPhone{ get; set; }

        public string ServInstruct{ get; set; }

        public bool ServRelease{ get; set; }

        public string ServAuthNum{ get; set; }

        public string ServRef1{ get; set; }

        public bool CommercialInvoice{ get; set; }

        public string ServRef2{ get; set; }

        public bool ShipExprtDeclartn{ get; set; }

        public string ServRef3{ get; set; }

        public bool CertOfOrigin{ get; set; }

        public string ServRef4{ get; set; }

        public bool LetterOfInstr{ get; set; }

        public string ServRef5{ get; set; }

        public bool HazardousShipment{ get; set; }

        public bool OverrideCarrier{ get; set; }

        public bool IntrntlShip{ get; set; }

        public bool OverrideService{ get; set; }

        public bool DemandUseCustomerValues{ get; set; }

        public string TaxRegReason{ get; set; }

        public int EarlyBuffer{ get; set; }

        public string OrgRegCode{ get; set; }

        public int LateBuffer{ get; set; }

        public bool DemandUnitPriceDiff{ get; set; }

        public string DemandUnitPriceDiffAction{ get; set; }

        public bool ExcFromVal{ get; set; }

        public bool AddressVal{ get; set; }

        public bool DemandCheckForPart{ get; set; }

        public string DemandCheckForPartAction{ get; set; }

        public string FFID{ get; set; }

        public string FFAddress1{ get; set; }

        public string FFAddress2{ get; set; }

        public string FFCity{ get; set; }

        public string FFState{ get; set; }

        public string FFZip{ get; set; }

        public string FFCountry{ get; set; }

        public string FFContact{ get; set; }

        public string FFCompName{ get; set; }

        public string FFPhoneNum{ get; set; }

        public string ChangedBy{ get; set; }

        public System.Nullable<System.DateTime> ChangeDate{ get; set; }

        public int ChangeTime{ get; set; }

        public bool IndividualPackIDs{ get; set; }

        public int FFCountryNum{ get; set; }

        public bool NonStdPkg{ get; set; }

        public int DeliveryConf{ get; set; }

        public bool AddlHdlgFlag{ get; set; }

        public bool UPSQuantumView{ get; set; }

        public string UPSQVShipFromName{ get; set; }

        public string UPSQVMemo{ get; set; }

        public string FFAddress3{ get; set; }

        public bool ETCAddrChg{ get; set; }

        public bool IsAlternate{ get; set; }

        public int MasterCustNum{ get; set; }

        public string MasterShipToNum{ get; set; }

        public bool DemandCheckForRev{ get; set; }

        public string DemandCheckForRevAction{ get; set; }

        public bool DemandCheckPartialShip{ get; set; }

        public string DemandCheckShipAction{ get; set; }

        public bool DemandCloseRejSkd{ get; set; }

        public string DemandPricing{ get; set; }

        public decimal PriceTolerance{ get; set; }

        public bool CheckDateCapPromise{ get; set; }

        public bool CheckConfirmCapPromise{ get; set; }

        public bool CheckUpdateCapPromise{ get; set; }

        public string DemandCapPromiseDate{ get; set; }

        public string DemandCapPromiseAction{ get; set; }

        public string DemandCapPromiseUpdate{ get; set; }

        public bool OTSmartString{ get; set; }

        public string LegalName{ get; set; }

        public bool DemandCheckConfig{ get; set; }

        public string DemandCheckCfgAction{ get; set; }

        public bool WIWebShipTo{ get; set; }

        public System.Data.Linq.Binary SysRevID{ get; set; }

        public System.Guid SysRowID{ get; set; }

        public string AGApartment{ get; set; }

        public string AGExtraStreetNumber{ get; set; }

        public string AGFloor{ get; set; }

        public string AGGrossIncomeTaxID{ get; set; }

        public string AGLocationCode{ get; set; }

        public string AGNeighborhood{ get; set; }

        public string AGProvinceCode{ get; set; }

        public string AGStreet{ get; set; }

        public string AGStreetNumber{ get; set; }

        public string EntityUseCode{ get; set; }

        public bool DemandCheckForRunOutPart{ get; set; }

        public string DemandCheckForRunOutPartAction{ get; set; }

        public string INExciseRegNumber{ get; set; }

        public string INVATNumber{ get; set; }

        public string INSTRegistration{ get; set; }

    }

    public class ShipHeadHDModel
    {
        public System.Guid ForeignSysRowID{ get; set; }

        public System.Data.Linq.Binary UDSysRevID{ get; set; }

        public bool ShipmentEmailSentc{ get; set; }

    }
}
