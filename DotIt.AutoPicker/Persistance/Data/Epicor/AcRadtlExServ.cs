using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcRadtlExServ
    {
        public string Company { get; set; }
        public decimal RadtlExServId { get; set; }
        public decimal Raid { get; set; }
        public string ExtraService { get; set; }
        public DateTime? EschangeDate { get; set; }
        public bool Ocsend { get; set; }
        public string OceventType { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public int CustNum { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
