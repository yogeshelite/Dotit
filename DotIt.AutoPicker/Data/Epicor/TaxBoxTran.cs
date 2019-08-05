﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxBoxTran
    {
        public string Company { get; set; }
        public DateTime TranDate { get; set; }
        public int TranNum { get; set; }
        public string BoxCode { get; set; }
        public decimal BoxAmount { get; set; }
        public decimal DocBoxAmount { get; set; }
        public decimal Rpt1BoxAmount { get; set; }
        public decimal Rpt2BoxAmount { get; set; }
        public decimal Rpt3BoxAmount { get; set; }
        public string ReportId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}