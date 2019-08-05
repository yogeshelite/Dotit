﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcBatchCat
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public int CycleUid { get; set; }
        public string CategoryId { get; set; }
        public string BookId { get; set; }
        public string Coacode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
