using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRahead
    {
        public string Company { get; set; }
        public decimal Raid { get; set; }
        public int SegNum { get; set; }
        public bool InitBcomplete { get; set; }
        public string InactiveRsn { get; set; }
        public string SegCtcd { get; set; }
        public bool Generated { get; set; }
        public DateTime? EffDt { get; set; }
        public bool Regenerate { get; set; }
        public string AccomCode { get; set; }
        public bool Ocsend { get; set; }
        public string OceventType { get; set; }
        public bool Ocready { get; set; }
        public string OtherRacs { get; set; }
        public DateTime? PreEntryLvDt { get; set; }
        public DateTime? CompletionDt { get; set; }
        public string EntryType { get; set; }
        public bool HighDep { get; set; }
        public int CustNum { get; set; }
        public DateTime? AccomEntryDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureRsnCode { get; set; }
        public string DepartureComments { get; set; }
        public int FacilityNum { get; set; }
        public string Seg1Cd { get; set; }
        public int PrimaryPerConId { get; set; }
        public bool RtrfHistFlag { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public DateTime? OrigAccomEntryDate { get; set; }
        public DateTime? OrigPreEntryLvDt { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public DateTime? UnfundedPriorEntryDt { get; set; }
        public string ReceivingPriorCare { get; set; }
        public string ElectedMeansTesting { get; set; }
        public bool Post1July2014 { get; set; }
        public string ClinicalRaid { get; set; }
    }
}
