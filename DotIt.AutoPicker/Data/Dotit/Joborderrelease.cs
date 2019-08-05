using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Joborderrelease
    {
        public Joborderrelease()
        {
            Jobmessage = new HashSet<Jobmessage>();
            Jobordbox = new HashSet<Jobordbox>();
            Jobordline = new HashSet<Jobordline>();
        }

        public int Joborid { get; set; }
        public int Jobid { get; set; }
        public int E10ordernum { get; set; }
        public int E10release { get; set; }
        public string Shipmethod { get; set; }
        public DateTime Shipbydate { get; set; }
        public DateTime Needbydate { get; set; }
        public decimal Publicrate { get; set; }
        public decimal Ourrate { get; set; }
        public string Trackingnumbers { get; set; }
        public string Packnumbers { get; set; }
        public string Invoices { get; set; }
        public decimal Kittingfee { get; set; }
        public bool Isots { get; set; }
        public string Customerid { get; set; }
        public int? Customernumber { get; set; }
        public string Shiptonumber { get; set; }
        public string Stcompany { get; set; }
        public string Stcontact { get; set; }
        public string Stcontactphone { get; set; }
        public string Stcontactemail { get; set; }
        public string Staddrline1 { get; set; }
        public string Staddrline2 { get; set; }
        public string Staddrline3 { get; set; }
        public string Stcity { get; set; }
        public string Ststate { get; set; }
        public string Stpostal { get; set; }
        public string Stcountry { get; set; }
        public bool Isorderheld { get; set; }
        public bool Iscalculateboxes { get; set; }
        public bool Ischargeshipping { get; set; }
        public bool Ischargekitting { get; set; }
        public bool Isaddressverified { get; set; }
        public DateTime Ordercreated { get; set; }
        public string Ordermodifiedby { get; set; }
        public DateTime Ordermodified { get; set; }
        public string Ponumber { get; set; }
        public string Jobponumber { get; set; }
        public decimal Shipdollars { get; set; }
        public decimal Ordersize { get; set; }
        public decimal? Weight { get; set; }

        public virtual Job Job { get; set; }
        public virtual ICollection<Jobmessage> Jobmessage { get; set; }
        public virtual ICollection<Jobordbox> Jobordbox { get; set; }
        public virtual ICollection<Jobordline> Jobordline { get; set; }
    }
}
