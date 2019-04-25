using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImworkStation
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
        public bool AutoQty { get; set; }
        public string WeightType { get; set; }
        public bool UseManifest { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string WebServiceUrl { get; set; }
        public string Type { get; set; }
        public string WeightCaptPt { get; set; }
        public string TransWum { get; set; }
        public string SizeUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int TimeOut { get; set; }
        public bool LogManifestMsg { get; set; }
    }
}
