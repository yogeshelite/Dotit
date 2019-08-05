using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartUom
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Uomcode { get; set; }
        public decimal ConvFactor { get; set; }
        public bool Active { get; set; }
        public bool TrackOnHand { get; set; }
        public decimal NetVolume { get; set; }
        public string NetVolumeUom { get; set; }
        public bool HasBeenUsed { get; set; }
        public string ConvOperator { get; set; }
        public bool WebUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
