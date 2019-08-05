using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Agcompany
    {
        public string Company { get; set; }
        public string GenFilesFolder { get; set; }
        public bool InvMoveMandCuit { get; set; }
        public bool SomandCuit { get; set; }
        public string DefaultDestination { get; set; }
        public string TransportKey { get; set; }
        public string WhcertificateSigner { get; set; }
        public string SignerPosition { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string WebServiceConfigCode { get; set; }
    }
}
