using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ContainerDuty
    {
        public ContainerDuty()
        {
            ContainerDutyTax = new HashSet<ContainerDutyTax>();
        }

        public string Company { get; set; }
        public int ContainerId { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public int DutySeq { get; set; }
        public string TariffCode { get; set; }
        public decimal DutyAmt { get; set; }
        public string CommentText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal InDutyAmt { get; set; }

        public virtual ICollection<ContainerDutyTax> ContainerDutyTax { get; set; }
    }
}
