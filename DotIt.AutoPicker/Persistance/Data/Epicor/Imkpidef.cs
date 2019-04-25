using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imkpidef
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
        public string AcrossCompanyId { get; set; }
        public string CompanyBaqfield { get; set; }
        public string KpimemberDesc { get; set; }
        public string Kpiname { get; set; }
        public int MemberLevel { get; set; }
        public string MemberParent { get; set; }
        public string MemberPriorPeer { get; set; }
        public string MemberNextPeer { get; set; }
        public string PeerRule { get; set; }
        public string ParentRule { get; set; }
        public string Baqid { get; set; }
        public string BaquseRules { get; set; }
        public bool BaqgetCurrValues { get; set; }
        public string Baqparam1 { get; set; }
        public string Baqparam2 { get; set; }
        public string Baqparam3 { get; set; }
        public string CalendarId { get; set; }
        public string CalendarIdbaqfield { get; set; }
        public string CalendarSuffix { get; set; }
        public int NumberOfPeriods { get; set; }
        public string TrendDisplay { get; set; }
        public string StatusDisplay { get; set; }
        public decimal Kpiweight { get; set; }
        public string KpiweightBaqfield { get; set; }
        public bool RangeLimit { get; set; }
        public decimal GoalRangeUpper { get; set; }
        public decimal GoalRangeLower { get; set; }
        public decimal Goal { get; set; }
        public string GoalBaqfield { get; set; }
        public decimal StretchGoal { get; set; }
        public string StretchGoalBaqfield { get; set; }
        public decimal TrendConstant { get; set; }
        public string TrendBaqfield { get; set; }
        public string TrendDisplayType { get; set; }
        public bool UseBaqlabels { get; set; }
        public decimal GoodTarget { get; set; }
        public string GoodTargetBaqfield { get; set; }
        public decimal Oktarget { get; set; }
        public string OktargetBaqfield { get; set; }
        public decimal BadTarget { get; set; }
        public string BadTargetBaqfield { get; set; }
        public decimal Target3 { get; set; }
        public string Target3Baqfield { get; set; }
        public decimal Target4 { get; set; }
        public string Target4Baqfield { get; set; }
        public decimal Target5 { get; set; }
        public string Target5Baqfield { get; set; }
        public bool CalendarComparison { get; set; }
        public string CalendarAggregateRules { get; set; }
        public string ValidComparison1 { get; set; }
        public string ValidComp1AggrRules { get; set; }
        public string ValidComparison2 { get; set; }
        public string ValidComp2AggrRules { get; set; }
        public string ValidComparison3 { get; set; }
        public string ValidComp3AggrRules { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
