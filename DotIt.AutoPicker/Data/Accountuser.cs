using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data
{
    public partial class Accountuser
    {
        public Accountuser()
        {
            TicketAssigneduserNavigation = new HashSet<Ticket>();
            TicketReportinguserNavigation = new HashSet<Ticket>();
            Usersession = new HashSet<Usersession>();
        }

        public int Userid { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string E10userid { get; set; }
        public string E10password { get; set; }
        public int? Partnerid { get; set; }

        public virtual ICollection<Ticket> TicketAssigneduserNavigation { get; set; }
        public virtual ICollection<Ticket> TicketReportinguserNavigation { get; set; }
        public virtual ICollection<Usersession> Usersession { get; set; }
    }
}
