using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Server
    {
        public Server()
        {
            Application = new HashSet<Application>();
            Ticket = new HashSet<Ticket>();
        }

        public int Serverid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
