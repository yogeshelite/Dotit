using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AgemissionPoint
    {
        public string Company { get; set; }
        public string EmissionPointId { get; set; }
        public string TranDocTypeId { get; set; }
        public string DocumentLetter { get; set; }
        public string InvoicingPoint { get; set; }
        public string PrintingControlType { get; set; }
        public string LegalNumberId { get; set; }
        public string AltEmissionPointId { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
