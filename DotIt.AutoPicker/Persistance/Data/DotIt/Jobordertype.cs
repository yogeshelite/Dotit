using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.DotIt
{
    public partial class Jobordertype
    {
        public Jobordertype()
        {
            Job = new HashSet<Job>();
        }

        public int Ordertypeid { get; set; }
        public string Ordertype { get; set; }

        public virtual ICollection<Job> Job { get; set; }
    }
}
