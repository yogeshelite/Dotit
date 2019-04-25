using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imkpidata
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Kpicode { get; set; }
        public string KpimemberId { get; set; }
        public int Kpiseq { get; set; }
        public string Kpiname { get; set; }
        public string FieldData { get; set; }
        public string FieldDataBaqfield { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public decimal TrendConstant { get; set; }
        public decimal Goal { get; set; }
        public decimal BaseGoal { get; set; }
        public decimal Rpt1Goal { get; set; }
        public decimal Rpt2Goal { get; set; }
        public decimal Rpt3Goal { get; set; }
        public decimal StretchGoal { get; set; }
        public decimal BaseStretchGoal { get; set; }
        public decimal Rpt1StretchGoal { get; set; }
        public decimal Rpt2StretchGoal { get; set; }
        public decimal Rpt3StretchGoal { get; set; }
        public decimal GoodTarget { get; set; }
        public string GoodTargetLabel { get; set; }
        public decimal BaseGoodTarget { get; set; }
        public decimal Rpt1GoodTarget { get; set; }
        public decimal Rpt2GoodTarget { get; set; }
        public decimal Rpt3GoodTarget { get; set; }
        public decimal Oktarget { get; set; }
        public string OktargetLabel { get; set; }
        public decimal BaseOktarget { get; set; }
        public decimal Rpt1Oktarget { get; set; }
        public decimal Rpt2Oktarget { get; set; }
        public decimal Rpt3Oktarget { get; set; }
        public decimal BadTarget { get; set; }
        public string BadTargetLabel { get; set; }
        public decimal BaseBadTarget { get; set; }
        public decimal Rpt1BadTarget { get; set; }
        public decimal Rpt2BadTarget { get; set; }
        public decimal Rpt3BadTarget { get; set; }
        public decimal Target3 { get; set; }
        public string Target3Label { get; set; }
        public decimal BaseTarget3 { get; set; }
        public decimal Rpt1Target3 { get; set; }
        public decimal Rpt2Target3 { get; set; }
        public decimal Rpt3Target3 { get; set; }
        public decimal Target4 { get; set; }
        public string Target4Label { get; set; }
        public decimal BaseTarget4 { get; set; }
        public decimal Rpt1Target4 { get; set; }
        public decimal Rpt2Target4 { get; set; }
        public decimal Rpt3Target4 { get; set; }
        public decimal Target5 { get; set; }
        public string Target5Label { get; set; }
        public decimal BaseTarget5 { get; set; }
        public decimal Rpt1Target5 { get; set; }
        public decimal Rpt2Target5 { get; set; }
        public decimal Rpt3Target5 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
