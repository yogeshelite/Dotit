using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImopMaster
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string OpCode { get; set; }
        public string OpDesc { get; set; }
        public string OpTextId { get; set; }
        public string BuyerId { get; set; }
        public bool ApsprepOpF { get; set; }
        public string Optype { get; set; }
        public string CommentText { get; set; }
        public decimal BillLaborRate { get; set; }
        public decimal EstLabHours { get; set; }
        public int SchedPrecedence { get; set; }
        public string AnalysisCode { get; set; }
        public int PrimarySetupOpDtl { get; set; }
        public int PrimaryProdOpDtl { get; set; }
        public int VendorNum { get; set; }
        public bool Subcontract { get; set; }
        public bool PrdYldRecalcExpected { get; set; }
        public int PrdYldRecalcUnderPct { get; set; }
        public bool PrdYldShopWrnAlert { get; set; }
        public bool PrdYldShopWrn { get; set; }
        public int PrdYldShopWrnUnderPct { get; set; }
        public int PrdYldShopWrnOverPct { get; set; }
        public bool RestrictSubstance { get; set; }
        public string RoughCutCode { get; set; }
        public string SendAheadType { get; set; }
        public decimal SendAheadOffset { get; set; }
        public string PrjRoleList { get; set; }
        public string RoleCodeDefault { get; set; }
        public bool UseAllRoles { get; set; }
        public string Jdfmaterial { get; set; }
        public string Jdfdevice { get; set; }
        public string Jdfoperation { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMes { get; set; }
    }
}
