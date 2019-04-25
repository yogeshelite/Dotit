using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImesProdintent
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string RecId { get; set; }
        public string Company { get; set; }
        public string ProdIntentUserId { get; set; }
        public string ProdIntentDesc { get; set; }
        public bool? Inactive { get; set; }
        public string UirecIdentifier { get; set; }
        public string ProductType { get; set; }
        public string ProductTypeUi { get; set; }
        public string BookMtsizeId { get; set; }
        public string BookMtsizeUserId { get; set; }
        public decimal? BookMtwidth { get; set; }
        public int? BookMtwidthOvrd { get; set; }
        public decimal? BookMtlength { get; set; }
        public int? BookMtlengthOvrd { get; set; }
        public decimal? BookHinge { get; set; }
        public decimal? BookOverhangFace { get; set; }
        public decimal? BookOverhangFoot { get; set; }
        public decimal? BookOverhangHead { get; set; }
        public decimal? BookCoverWraparound { get; set; }
        public decimal? BookJacketTurnover { get; set; }
        public decimal? BookJacketFlapFront { get; set; }
        public decimal? BookJacketFlapBack { get; set; }
        public string BookSpineAdjId { get; set; }
        public string BookSpineAdjUserId { get; set; }
        public string BookSpineAdjDesc { get; set; }
        public int? BookSpineAdjDescOvrd { get; set; }
        public decimal? BookSpineXfactor { get; set; }
        public int? BookSpineXfactorOvrd { get; set; }
        public decimal? BookSpineAdditionFactor { get; set; }
        public int? BookSpineAdditionFactorOvrd { get; set; }
        public decimal? BookSpineRoundupFactor { get; set; }
        public int? BookSpineRoundupFactorOvrd { get; set; }
        public decimal? Book3Pshow { get; set; }
        public decimal? Book3PsidePanelOvlp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public string UserChar5 { get; set; }
        public string UserChar6 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public DateTime? UserDate5 { get; set; }
        public DateTime? UserDate6 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public decimal? UserDecimal9 { get; set; }
        public decimal? UserDecimal10 { get; set; }
        public decimal? UserDecimal11 { get; set; }
        public decimal? UserDecimal12 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }
        public int? UserInteger5 { get; set; }
        public int? UserInteger6 { get; set; }
        public decimal? SoftCoverFlapFront { get; set; }
        public decimal? SoftCoverFlapBack { get; set; }
        public decimal? MinHbandLength { get; set; }
        public decimal? BookPackWidthFactor { get; set; }
        public int? BookPackWidthFactorOvrd { get; set; }
    }
}
