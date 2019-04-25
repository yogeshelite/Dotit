using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcOcresponse
    {
        public string Company { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public decimal OcresponseId { get; set; }
        public decimal XmlrespId { get; set; }
        public decimal XmlparentId { get; set; }
        public decimal XmlorderId { get; set; }
        public string Xmlfield { get; set; }
        public string Xmlvalue { get; set; }
        public string Xmlnode { get; set; }
        public bool DisplayTree { get; set; }
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
