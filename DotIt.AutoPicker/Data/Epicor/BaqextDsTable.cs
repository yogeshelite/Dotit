﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BaqextDsTable
    {
        public string Company { get; set; }
        public string DatasourceType { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
