using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtPrexportLayout
    {
        public ExtPrexportLayout()
        {
            ExtPrexportSeq = new HashSet<ExtPrexportSeq>();
        }

        public string Company { get; set; }
        public string PayExportLayoutId { get; set; }
        public string Description { get; set; }
        public string ShortChar01 { get; set; }
        public string ShortChar02 { get; set; }
        public string ShortChar03 { get; set; }
        public string ShortChar04 { get; set; }
        public string ShortChar05 { get; set; }
        public string Character01 { get; set; }
        public string Character02 { get; set; }
        public string Character03 { get; set; }
        public string Character04 { get; set; }
        public string Character05 { get; set; }
        public decimal Number01 { get; set; }
        public decimal Number02 { get; set; }
        public decimal Number03 { get; set; }
        public decimal Number04 { get; set; }
        public decimal Number05 { get; set; }
        public int Number06 { get; set; }
        public int Number07 { get; set; }
        public int Number08 { get; set; }
        public int Number09 { get; set; }
        public int Number10 { get; set; }
        public DateTime? Date01 { get; set; }
        public DateTime? Date02 { get; set; }
        public DateTime? Date03 { get; set; }
        public bool Checkbox01 { get; set; }
        public bool Checkbox02 { get; set; }
        public bool Checkbox03 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ExtPrexportSeq> ExtPrexportSeq { get; set; }
    }
}
