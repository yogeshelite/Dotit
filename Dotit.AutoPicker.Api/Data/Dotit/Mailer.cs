using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Mailer
    {
        public Mailer()
        {
            Mailerpayment = new HashSet<Mailerpayment>();
        }

        public int Storeid { get; set; }
        public string Email { get; set; }
        public string Storename { get; set; }
        public string Namecard { get; set; }
        public string Card { get; set; }
        public string Cvv { get; set; }
        public string Expire { get; set; }
        public string Zip { get; set; }
        public decimal? Amount { get; set; }
        public bool Isoptedin { get; set; }
        public DateTime? Whenoptedin { get; set; }
        public string Custid { get; set; }
        public int Custnum { get; set; }

        public virtual ICollection<Mailerpayment> Mailerpayment { get; set; }
    }
}
