﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcValueInputLayerDetail
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int GroupSeq { get; set; }
        public int HeadNum { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public string ImageLayerId { get; set; }
        public int LayerSeq { get; set; }
        public string LayerName { get; set; }
        public string LayerDesc { get; set; }
        public int Zindex { get; set; }
        public string ImageId { get; set; }
        public string FileType { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public string Category { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
