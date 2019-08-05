using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRtrfHist
    {
        public string Company { get; set; }
        public decimal RtrfHistId { get; set; }
        public DateTime? TrfDt { get; set; }
        public decimal Raid { get; set; }
        public int CustNum { get; set; }
        public int SegNum { get; set; }
        public int FromSegNum { get; set; }
        public int ToSegNum { get; set; }
        public int FacilityNum { get; set; }
        public int Seg1Id { get; set; }
        public DateTime? FromAccomEntryDt { get; set; }
        public DateTime? FromAccomDptrDt { get; set; }
        public string TrfRsn { get; set; }
        public string StatusFlag { get; set; }
        public string Seg1Cd { get; set; }
        public string DepartureRsnCode { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string SegCtcd { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
