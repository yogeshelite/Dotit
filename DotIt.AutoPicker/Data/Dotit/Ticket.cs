using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Ticket
    {
        public int Ticketid { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public int Reportinguser { get; set; }
        public int? Assigneduser { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
        public int Applicationid { get; set; }
        public int? Serverid { get; set; }
        public DateTime? Resolutiondate { get; set; }
        public string Resolution { get; set; }

        public virtual Application Application { get; set; }
        public virtual Accountuser AssigneduserNavigation { get; set; }
        public virtual Accountuser ReportinguserNavigation { get; set; }
        public virtual Server Server { get; set; }
    }
}
