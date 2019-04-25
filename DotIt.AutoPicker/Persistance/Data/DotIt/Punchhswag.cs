using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.DotIt
{
    public partial class Punchhswag
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Delname { get; set; }
        public string Delattn { get; set; }
        public string Deladdr { get; set; }
        public string Delcity { get; set; }
        public string Delstate { get; set; }
        public string Delpostal { get; set; }
        public string Delcountry { get; set; }
        public string Deloriginaladdr { get; set; }
        public string Delemail { get; set; }
        public string Delphone { get; set; }
        public bool Delvalidated { get; set; }
        public string Fbloc { get; set; }
        public string Fblocname { get; set; }
        public string Fbstorenum { get; set; }
        public string Fbredemptioncode { get; set; }
        public int Fbpointsreq { get; set; }
        public int Fbpointsredeemed { get; set; }
        public string Fbredeemdate { get; set; }
        public string Fbredeempartid { get; set; }
        public string Fbredeemsize { get; set; }
        public string Dotitpart { get; set; }
        public string Tranreceivedate { get; set; }
        public string Origip { get; set; }
        public string Orderstatus { get; set; }
        public string Shipdate { get; set; }
        public string Shipvia { get; set; }
        public string Trackingnumber { get; set; }
        public int E10ordernumber { get; set; }
        public int Packnum { get; set; }
        public decimal Weight { get; set; }
        public decimal Ourrate { get; set; }
        public decimal Publicrate { get; set; }
        public bool Istest { get; set; }
        public int? Sweepid { get; set; }
        public bool Isresidential { get; set; }
        public int? Endiciatransid { get; set; }
    }
}
