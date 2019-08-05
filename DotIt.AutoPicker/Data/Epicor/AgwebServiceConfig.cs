using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AgwebServiceConfig
    {
        public string Company { get; set; }
        public string WebServiceConfigCode { get; set; }
        public string Description { get; set; }
        public string AuthUrl { get; set; }
        public string WebServiceUrl { get; set; }
        public string CertificateCode { get; set; }
        public int AuthUniqueId { get; set; }
        public int ExportDocumentId { get; set; }
        public string Token { get; set; }
        public string Sign { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? GenerationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int ConfigurationType { get; set; }
    }
}
