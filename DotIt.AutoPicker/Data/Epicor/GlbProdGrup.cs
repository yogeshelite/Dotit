﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbProdGrup
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string JobClosingCode { get; set; }
        public string JobCompletionCode { get; set; }
        public string PersonId { get; set; }
        public string Plant { get; set; }
        public string PriceGroupCode { get; set; }
        public string ProdCode { get; set; }
        public string RoughCutCode { get; set; }
        public string TaxCatId { get; set; }
        public string WarrantyCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbProdCode { get; set; }
        public bool Skipped { get; set; }
        public bool DeferredRev { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalProdGrup { get; set; }
        public string Racode { get; set; }
        public string ProdFamilyId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
