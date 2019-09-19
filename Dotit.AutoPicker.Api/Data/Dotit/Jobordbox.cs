using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Jobordbox
    {
        public Jobordbox()
        {
            Jobmessage = new HashSet<Jobmessage>();
            Jobordline = new HashSet<Jobordline>();
        }

        public int Jobboxid { get; set; }
        public int Joborid { get; set; }
        public int E10boxnumber { get; set; }
        public decimal Boxweight { get; set; }
        public string Trackingnumber { get; set; }
        public string Packnumber { get; set; }
        public string Shippingstatus { get; set; }
        public decimal? Boxcubicin { get; set; }
        public int? Boxlength { get; set; }
        public int? Boxwidth { get; set; }
        public int? Boxheight { get; set; }

        public virtual Joborderrelease Jobor { get; set; }
        public virtual ICollection<Jobmessage> Jobmessage { get; set; }
        public virtual ICollection<Jobordline> Jobordline { get; set; }
    }
}
