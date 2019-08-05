﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImlocationInventory
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public long LocationNum { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string JobNum { get; set; }
        public string CurrentOwner { get; set; }
        public string OrderComment { get; set; }
        public string LineDesc { get; set; }
        public string Listing { get; set; }
        public DateTime? ListingStartDate { get; set; }
        public string WarrantyCode { get; set; }
        public string WarrantyComment { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyExpirationDate { get; set; }
        public string LotNum { get; set; }
        public string SerialNumber { get; set; }
        public string Idnum { get; set; }
        public string WarrantyTransfer { get; set; }
        public string XpartNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}