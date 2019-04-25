using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Immicrprinter
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string MicrprinterId { get; set; }
        public bool DefaultPrinter { get; set; }
        public string OnUsSymbol { get; set; }
        public string TransitSymbol { get; set; }
        public string DashSymbol { get; set; }
        public string Micrfont { get; set; }
        public string PrinterId { get; set; }
        public string SignatureType { get; set; }
        public string SignatureImageId { get; set; }
        public string SignatureFont { get; set; }
        public string SignatureText01 { get; set; }
        public string SignatureText02 { get; set; }
        public string SignatureText03 { get; set; }
        public string SignatureText04 { get; set; }
        public string SignatureText05 { get; set; }
        public string SignatureText06 { get; set; }
        public string LogoType { get; set; }
        public string LogoImageId { get; set; }
        public string LogoFont { get; set; }
        public string LogoText01 { get; set; }
        public string LogoText02 { get; set; }
        public string LogoText03 { get; set; }
        public string LogoText04 { get; set; }
        public string LogoText05 { get; set; }
        public string LogoText06 { get; set; }
        public bool IsClient { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
