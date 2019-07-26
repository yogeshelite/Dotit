using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Apikey
    {
        public string Company { get; set; }
        public string KeyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string PrefixKey { get; set; }
        public string HashKey { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public bool SystemFlag { get; set; }
        public bool HasShown { get; set; }
        public int CompanyVisibility { get; set; }
        public bool Enabled { get; set; }
        public string AccessScopeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
