using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Task
    {
        public string Company { get; set; }
        public string RelatedToFile { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string TaskId { get; set; }
        public int TaskSeqNum { get; set; }
        public string TaskDescription { get; set; }
        public string SalesRepCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string StatusCode { get; set; }
        public int PercentComplete { get; set; }
        public bool Complete { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string CurrentStage { get; set; }
        public bool Mandatory { get; set; }
        public bool Milestone { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateDcdUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeDcdUserId { get; set; }
        public bool SendAlertComplete { get; set; }
        public int PriorityCode { get; set; }
        public string TaskComment { get; set; }
        public string Conclusion { get; set; }
        public string ReasonCode { get; set; }
        public string NextTaskId { get; set; }
        public int NextTaskSeq { get; set; }
        public int TaskQuoteNum { get; set; }
        public int TaskCustNum { get; set; }
        public string TaskShipToNum { get; set; }
        public int TaskConNum { get; set; }
        public string TaskSetId { get; set; }
        public int TaskSetSeq { get; set; }
        public bool CreateOrder { get; set; }
        public bool SendAlertCreate { get; set; }
        public string TypeCode { get; set; }
        public int TaskVendorNum { get; set; }
        public string TaskPurPoint { get; set; }
        public int TaskPrcConNum { get; set; }
        public string TaskMktgCampaignId { get; set; }
        public string OtherSalesRepCode { get; set; }
        public bool CustomerCategory { get; set; }
        public bool EngineeringCategory { get; set; }
        public bool VendorCategory { get; set; }
        public bool PersonalCategory { get; set; }
        public bool ManagementCategory { get; set; }
        public bool OtherCategory { get; set; }
        public string RoleCode { get; set; }
        public int ChangeTime { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public bool AnyApprover { get; set; }
        public int ApprovalSupervisorLevel { get; set; }
        public bool Approved { get; set; }
        public string CompletionAction { get; set; }
        public bool AutoComplete { get; set; }
        public bool RejectApproval { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int TaskShipToCustNum { get; set; }
        public int TaskShipToCustConNum { get; set; }
        public bool Voided { get; set; }
        public int TaskPerConId { get; set; }
        public bool PrevTaskSetTask { get; set; }
    }
}
