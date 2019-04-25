using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysRptLst
    {
        public string Company { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public long RecSeq { get; set; }
        public string RptDescription { get; set; }
        public long SysTaskNum { get; set; }
        public string HostComputer { get; set; }
        public string FileName { get; set; }
        public string RptStatus { get; set; }
        public DateTime? LastActionOn { get; set; }
        public string LastAction { get; set; }
        public string OutPutToPrinter { get; set; }
        public string AutoAction { get; set; }
        public string PrintDriver { get; set; }
        public string PrintProgram { get; set; }
        public string PrinterName { get; set; }
        public string PrintProgramOptions { get; set; }
        public string RptPageSettings { get; set; }
        public string RptPrinterSettings { get; set; }
        public string RptVersion { get; set; }
        public string RptOutPutType { get; set; }
        public string WorkStationId { get; set; }
        public string RptNote { get; set; }
        public bool Archived { get; set; }
        public DateTime? PurgeDate { get; set; }
        public int TxtLpp { get; set; }
        public string FaxSubject { get; set; }
        public string FaxTo { get; set; }
        public string FaxNumber { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public string Ssrsurl { get; set; }
        public string OutputEdi { get; set; }
        public string EmailBody { get; set; }
        public string AttachmentType { get; set; }
        public string SsrsrenderFormat { get; set; }
        public byte[] RptData { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ReportId { get; set; }
        public int? StyleNum { get; set; }
        public string UserDescription { get; set; }
        public string DesignMode { get; set; }
        public string DesignUser { get; set; }
        public string DesignVersionLocalFolder { get; set; }
        public string StyleDescription { get; set; }
    }
}
