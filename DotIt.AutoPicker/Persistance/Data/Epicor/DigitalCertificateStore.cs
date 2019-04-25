using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DigitalCertificateStore
    {
        public string Company { get; set; }
        public string CertificateId { get; set; }
        public int CompanyVisibility { get; set; }
        public string CryptographyType { get; set; }
        public string ThumbPrint { get; set; }
        public string Issuer { get; set; }
        public string Subject { get; set; }
        public int Version { get; set; }
        public DateTime ExpiredOn { get; set; }
        public DateTime ValidOn { get; set; }
        public byte[] CertificateContent { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }
    }
}
