using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Mailerpayment
    {
        public int Mpid { get; set; }
        public int Storeid { get; set; }
        public short Payment { get; set; }
        public decimal? Amounttocharge { get; set; }
        public decimal? Basecharge { get; set; }
        public decimal? Taxes { get; set; }
        public DateTime? Datecharged { get; set; }
        public decimal? Actualcharge { get; set; }
        public bool Isvalidcard { get; set; }

        public virtual Mailer Store { get; set; }
    }
}
