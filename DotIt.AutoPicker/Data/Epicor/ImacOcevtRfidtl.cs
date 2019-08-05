﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacOcevtRfidtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal OcevtRfidtlId { get; set; }
        public decimal OcevtRfiid { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public decimal XmltreeId { get; set; }
        public string XmlnodeText { get; set; }
        public decimal XmlparentId { get; set; }
        public decimal Xmllevel { get; set; }
        public bool DisplayGrid { get; set; }
        public string RfidtlDomain { get; set; }
        public string RfidtlQuestion { get; set; }
        public string RfidtlLabel { get; set; }
        public string RfidtlValue { get; set; }
        public string RfidtlDescription { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
