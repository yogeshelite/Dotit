using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcOcevtRfi
    {
        public string Company { get; set; }
        public decimal OcevtRfiid { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public string AppraiserLname { get; set; }
        public string AppraiserFname { get; set; }
        public string AppraiserPsn { get; set; }
        public string AppraisalType { get; set; }
        public DateTime? ReEntryDt { get; set; }
        public decimal RadtlId { get; set; }
        public int CustNum { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
