using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImquoteMtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public decimal QtyPer { get; set; }
        public string Ium { get; set; }
        public bool Direct { get; set; }
        public int LeadTime { get; set; }
        public int RelatedOperation { get; set; }
        public string SalvagePartNum { get; set; }
        public string SalvageDescription { get; set; }
        public decimal SalvageQtyPer { get; set; }
        public string SalvageUm { get; set; }
        public decimal SalvageUnitCredit { get; set; }
        public decimal SalvageMtlBurRate { get; set; }
        public decimal SalvageEstMtlBurUnitCredit { get; set; }
        public string MfgComment { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public bool BuyIt { get; set; }
        public string PurComment { get; set; }
        public decimal MinimumCost { get; set; }
        public decimal EstUnitCost { get; set; }
        public decimal MtlBurRate { get; set; }
        public decimal EstMtlBurUnitCost { get; set; }
        public decimal RequiredQty { get; set; }
        public decimal EstScrap { get; set; }
        public string EstScrapType { get; set; }
        public bool FixedQty { get; set; }
        public string FindNum { get; set; }
        public string Class { get; set; }
        public string ApsaddResType { get; set; }
        public bool Rfqneeded { get; set; }
        public int RfqvendQuotes { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public string Rfqstat { get; set; }
        public string AnalysisCode { get; set; }
        public bool GlbRfq { get; set; }
        public decimal PbrkCost02 { get; set; }
        public decimal PbrkCost03 { get; set; }
        public decimal PbrkCost04 { get; set; }
        public decimal PbrkCost05 { get; set; }
        public decimal PbrkCost06 { get; set; }
        public decimal PbrkCost07 { get; set; }
        public decimal PbrkCost08 { get; set; }
        public decimal PbrkCost09 { get; set; }
        public decimal PbrkCost10 { get; set; }
        public decimal PbrkQty01 { get; set; }
        public decimal PbrkQty02 { get; set; }
        public decimal PbrkQty03 { get; set; }
        public decimal PbrkQty04 { get; set; }
        public decimal PbrkQty05 { get; set; }
        public decimal PbrkQty06 { get; set; }
        public decimal PbrkQty07 { get; set; }
        public decimal PbrkQty08 { get; set; }
        public decimal PbrkQty09 { get; set; }
        public decimal PbrkQty10 { get; set; }
        public decimal PbrkCost01 { get; set; }
        public int ReqRefDes { get; set; }
        public string BasePartNum { get; set; }
        public string BaseRevisionNum { get; set; }
        public int GroupSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string OrigStructTag { get; set; }
        public int OrigGroupSeq { get; set; }
        public decimal EstMtlUnitCost { get; set; }
        public bool LinkToContract { get; set; }
        public string ContractId { get; set; }
        public string MiscCode { get; set; }
        public bool MiscCharge { get; set; }
        public bool PclinkRemoved { get; set; }
        public int PlmmtlSeq { get; set; }
        public bool LocationView { get; set; }
    }
}
