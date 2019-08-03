using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data
{
    public partial class YextHeader
    {
        public YextHeader()
        {
            YextDetail = new HashSet<YextDetail>();
        }

        public int Yextid { get; set; }
        public bool Isactive { get; set; }
        public bool Isautorenew { get; set; }
        public decimal Nextfee { get; set; }
        public DateTime Renewaldate { get; set; }
        public DateTime Startdate { get; set; }
        public string Yextssotoken { get; set; }
        public string Yextcustnum { get; set; }
        public int Epicorcustnum { get; set; }
        public int? Magentocustnum { get; set; }
        public string Magentoemail { get; set; }
        public DateTime Createdate { get; set; }
        public string Createdby { get; set; }
        public DateTime Modifieddate { get; set; }
        public string Modifiedby { get; set; }

        public virtual ICollection<YextDetail> YextDetail { get; set; }
    }
}
