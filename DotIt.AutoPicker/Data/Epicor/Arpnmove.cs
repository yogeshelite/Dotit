using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Arpnmove
    {
        public string Company { get; set; }
        public int HeadNum { get; set; }
        public string GroupId { get; set; }
        public int Seq { get; set; }
        public string CurGroupId { get; set; }
        public string Pistatus { get; set; }
        public string Pistage { get; set; }
        public bool Posted { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string LegalNumber { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public DateTime? TranDate { get; set; }
        public int CreateTime { get; set; }
        public string TranDocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
