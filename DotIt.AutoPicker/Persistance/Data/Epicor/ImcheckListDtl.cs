using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcheckListDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ListId { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string CommentText { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal PercentComplete { get; set; }
        public DateTime? DateComplete { get; set; }
        public string StepStatus { get; set; }
        public string DcdUserId { get; set; }
        public string Phase { get; set; }
        public string MenuId { get; set; }
        public string HelpId { get; set; }
        public string TutorialId { get; set; }
        public string TraningUrl { get; set; }
        public string LinkListId { get; set; }
        public int OrderSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
