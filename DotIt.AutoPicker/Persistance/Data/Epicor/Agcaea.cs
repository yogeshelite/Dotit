using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Agcaea
    {
        public string Company { get; set; }
        public string Period { get; set; }
        public int Fortnight { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string Caea { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
