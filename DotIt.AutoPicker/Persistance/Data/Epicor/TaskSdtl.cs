using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaskSdtl
    {
        public string Company { get; set; }
        public string TaskSetId { get; set; }
        public int TaskSetSeq { get; set; }
        public string TaskId { get; set; }
        public string TaskDescription { get; set; }
        public bool Milestone { get; set; }
        public int ParentTaskSeq { get; set; }
        public string CurrentStage { get; set; }
        public bool WinAllowed { get; set; }
        public bool LoseAllowed { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateDcdUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeDcdUserId { get; set; }
        public bool Mandatory { get; set; }
        public int DaysToComplete { get; set; }
        public bool EcocheckOutAllowed { get; set; }
        public bool EcocheckInAllowed { get; set; }
        public bool WfcompleteAllowed { get; set; }
        public string RoleCode { get; set; }
        public string CompletionAction { get; set; }
        public bool AutoComplete { get; set; }
        public bool SubmitTask { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
