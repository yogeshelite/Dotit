﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImresourceCollection
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CollectionId { get; set; }
        public string Description { get; set; }
        public string ResourceGroupList { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}