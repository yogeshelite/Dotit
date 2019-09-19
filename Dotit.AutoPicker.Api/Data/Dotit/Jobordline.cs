using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Jobordline
    {
        public Jobordline()
        {
            Jobmessage = new HashSet<Jobmessage>();
        }

        public int Joblineid { get; set; }
        public int Joborid { get; set; }
        public int? Jobboxid { get; set; }
        public int E10linenum { get; set; }
        public string Partnum { get; set; }
        public int Orderqty { get; set; }
        public bool Ispartvalid { get; set; }
        public bool Isqtyonhand { get; set; }
        public DateTime Linecreated { get; set; }
        public string Linemodifiedby { get; set; }
        public DateTime Linemodified { get; set; }
        public string Comment { get; set; }

        public virtual Jobordbox Jobbox { get; set; }
        public virtual Joborderrelease Jobor { get; set; }
        public virtual ICollection<Jobmessage> Jobmessage { get; set; }
    }
}
