using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Websales
    {
        public int Wsid { get; set; }
        public DateTime Saledate { get; set; }
        public string Custgroup { get; set; }
        public string Custname { get; set; }
        public int Transactions { get; set; }
        public int Sales { get; set; }
    }
}
