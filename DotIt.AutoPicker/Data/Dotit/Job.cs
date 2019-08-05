using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Job
    {
        public Job()
        {
            Jobmessage = new HashSet<Jobmessage>();
            Joborderrelease = new HashSet<Joborderrelease>();
        }

        public int Jobid { get; set; }
        public string Jobname { get; set; }
        public int Ordertype { get; set; }
        public string Subfolder { get; set; }
        public bool Isactive { get; set; }
        public string Jobcreator { get; set; }
        public DateTime Jobcreationdate { get; set; }
        public string Jobmodifier { get; set; }
        public DateTime Jobmodifieddate { get; set; }
        public DateTime Shipbydate { get; set; }
        public int Custnum { get; set; }
        public string Custname { get; set; }
        public string Custid { get; set; }
        public int Orders { get; set; }
        public bool Isonebillingcustomer { get; set; }
        public bool Ischargekitting { get; set; }
        public bool Ischargeshipping { get; set; }
        public bool Iscalcboxes { get; set; }
        public bool Isholdorder { get; set; }
        public bool Isshipordercomplete { get; set; }
        public bool Isgenpacklistlabels { get; set; }
        public bool Isgenshippinglabels { get; set; }
        public decimal Ordersize { get; set; }
        public decimal Kitdollars { get; set; }
        public decimal Shipdollars { get; set; }
        public decimal Kittingfee { get; set; }
        public decimal Ourrate { get; set; }
        public string Shipvia { get; set; }
        public bool Isautopackout { get; set; }
        public bool Iskitcommish { get; set; }

        public virtual Jobordertype OrdertypeNavigation { get; set; }
        public virtual ICollection<Jobmessage> Jobmessage { get; set; }
        public virtual ICollection<Joborderrelease> Joborderrelease { get; set; }
    }
}
