using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcPcinValue
    {
        public string InputName { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int Sequence { get; set; }
        public Guid SysRowId { get; set; }
        public string RuleTag { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public string RelatedToFile { get; set; }
        public string RelatedType { get; set; }
        public bool CreateCase { get; set; }
        public string CarePlanType { get; set; }
        public string CaseSummary { get; set; }
        public string CaseDescription { get; set; }
        public string WorkflowType { get; set; }
        public string WfgroupId { get; set; }
        public string TopicId1 { get; set; }
        public string TopicId2 { get; set; }
        public string TopicId3 { get; set; }
        public string TopicId4 { get; set; }
        public string TopicId5 { get; set; }
        public string TopicId6 { get; set; }
        public string TopicId7 { get; set; }
        public string TopicId8 { get; set; }
        public string TopicId9 { get; set; }
        public string TopicId10 { get; set; }
        public bool MedicalRecord { get; set; }
        public string CaseTopics { get; set; }
        public string TaskSetId { get; set; }
        public bool CasePosted { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
