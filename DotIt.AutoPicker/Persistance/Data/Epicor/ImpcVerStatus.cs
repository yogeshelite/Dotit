using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpcVerStatus
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string StringStyle { get; set; }
        public string Separator { get; set; }
        public string NumberFormat { get; set; }
        public int StartNumber { get; set; }
        public bool CrtCustPart { get; set; }
        public bool PrefacePart { get; set; }
        public int ConfigVersion { get; set; }
        public string QuotePcode { get; set; }
        public string OrderPcode { get; set; }
        public bool OrdQuoCom { get; set; }
        public bool JobPickCom { get; set; }
        public bool ShipCom { get; set; }
        public bool InvCom { get; set; }
        public bool CreatePart { get; set; }
        public string CrtPartUsing { get; set; }
        public bool InQuoting { get; set; }
        public bool AutoCrtPart { get; set; }
        public bool NotUnique { get; set; }
        public bool InOrderEntry { get; set; }
        public bool InJobEntry { get; set; }
        public bool CreateBom { get; set; }
        public bool ZeroCost { get; set; }
        public bool CrtPartDesc { get; set; }
        public string FileName { get; set; }
        public bool SingleLevelConf { get; set; }
        public bool SaveInputValues { get; set; }
        public bool SetPartNumOnly { get; set; }
        public string Comments { get; set; }
        public bool AprvRev { get; set; }
        public bool EntprsConf { get; set; }
        public bool Synchronize { get; set; }
        public bool DispConfSummary { get; set; }
        public string PartComments { get; set; }
        public bool CompPricing { get; set; }
        public bool ExtConfig { get; set; }
        public string ExtMfgCompId { get; set; }
        public bool AllAltMethods { get; set; }
        public bool AllowReconPo { get; set; }
        public bool CompPricingJobMethod { get; set; }
        public bool CreateRev { get; set; }
        public bool DefaultEco { get; set; }
        public bool GenerateMethod { get; set; }
        public bool PromptForConfig { get; set; }
        public bool PromptForCheckout { get; set; }
        public bool RemoveLink { get; set; }
        public bool SivaluesUseGenMethod { get; set; }
        public bool UseSavedLayout { get; set; }
        public string ConfigType { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
