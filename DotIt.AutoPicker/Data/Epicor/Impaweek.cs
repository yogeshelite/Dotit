using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Impaweek
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PaweekId { get; set; }
        public string PawkDescription { get; set; }
        public string Pasun { get; set; }
        public string Pamon { get; set; }
        public string Patue { get; set; }
        public string Pawed { get; set; }
        public string Pathu { get; set; }
        public string Pafri { get; set; }
        public string Pasat { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
