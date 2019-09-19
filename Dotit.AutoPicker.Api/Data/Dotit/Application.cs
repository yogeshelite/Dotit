using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Application
    {
        public Application()
        {
            Appconfig = new HashSet<Appconfig>();
            Ticket = new HashSet<Ticket>();
        }

        public int Applicationid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currentversion { get; set; }
        public int Serverid { get; set; }
        public bool Isactive { get; set; }
        public bool Isinticket { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        public virtual Server Server { get; set; }
        public virtual ICollection<Appconfig> Appconfig { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
