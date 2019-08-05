using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImmaintReq
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string ReqId { get; set; }
        public string EquipId { get; set; }
        public bool OpenReq { get; set; }
        public string ReqStatus { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string Priority { get; set; }
        public string IssueDesc { get; set; }
        public string Requestor { get; set; }
        public string Reviewer { get; set; }
        public DateTime? RequestDt { get; set; }
        public int RequestTime { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int ResponseTime { get; set; }
        public string JobNum { get; set; }
        public string ResDesc { get; set; }
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
        public string ResTopicId1 { get; set; }
        public string ResTopicId2 { get; set; }
        public string ResTopicId3 { get; set; }
        public string ResTopicId4 { get; set; }
        public string ResTopicId5 { get; set; }
        public string ResTopicId6 { get; set; }
        public string ResTopicId7 { get; set; }
        public string ResTopicId8 { get; set; }
        public string ResTopicId9 { get; set; }
        public string ResTopicId10 { get; set; }
        public int HdcaseNum { get; set; }
        public string MaintPlant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
