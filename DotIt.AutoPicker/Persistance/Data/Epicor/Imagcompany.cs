using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imagcompany
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
