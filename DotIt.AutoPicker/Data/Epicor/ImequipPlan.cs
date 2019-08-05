using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImequipPlan
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EquipId { get; set; }
        public int PlanNum { get; set; }
        public bool InActive { get; set; }
        public string Description { get; set; }
        public int TimeFreq { get; set; }
        public string TimeUom { get; set; }
        public int MeterFreq { get; set; }
        public bool Recurs { get; set; }
        public DateTime? NextDate { get; set; }
        public int NextMeter { get; set; }
        public string TemplateJobNum { get; set; }
        public string ActionStatus { get; set; }
        public string IssueTopicId1 { get; set; }
        public string IssueTopicId2 { get; set; }
        public string IssueTopicId3 { get; set; }
        public string IssueTopicId4 { get; set; }
        public string IssueTopicId5 { get; set; }
        public string IssueTopicId6 { get; set; }
        public string IssueTopicId7 { get; set; }
        public string IssueTopicId8 { get; set; }
        public string IssueTopicId9 { get; set; }
        public string IssueTopicId10 { get; set; }
        public int MaintBuffer { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
