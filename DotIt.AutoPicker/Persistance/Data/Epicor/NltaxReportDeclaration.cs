using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class NltaxReportDeclaration
    {
        public NltaxReportDeclaration()
        {
            NltaxReportDeclarationDtl = new HashSet<NltaxReportDeclarationDtl>();
        }

        public string Company { get; set; }
        public int DeclarationUid { get; set; }
        public DateTime? DeclarationDate { get; set; }
        public bool Correction { get; set; }
        public string ReportId { get; set; }
        public int EftheadUid { get; set; }
        public string OutputFile { get; set; }
        public DateTime? LastExportedDate { get; set; }
        public string LastExportedBy { get; set; }
        public DateTime? LastSentDate { get; set; }
        public string LastSentBy { get; set; }
        public int SentStatus { get; set; }
        public string SentErrorMessage { get; set; }
        public string CurrencyCode { get; set; }
        public string RptComment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<NltaxReportDeclarationDtl> NltaxReportDeclarationDtl { get; set; }
    }
}
