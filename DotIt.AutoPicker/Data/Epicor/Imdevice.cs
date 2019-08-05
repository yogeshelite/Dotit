using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imdevice
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string WorkStationId { get; set; }
        public string Description { get; set; }
        public int Comport { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public int Parity { get; set; }
        public int StopBits { get; set; }
        public int TimeOut { get; set; }
        public string InquireMsg { get; set; }
        public bool AppendCr { get; set; }
        public string PrinterId { get; set; }
        public string PrinterUsage { get; set; }
        public string Type { get; set; }
        public bool DefaultDevice { get; set; }
        public string DeviceUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
