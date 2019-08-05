using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Jobmessage
    {
        public int Jobmessageid { get; set; }
        public int? Jobid { get; set; }
        public int? Joborid { get; set; }
        public int? Jobboxid { get; set; }
        public int? Joblineid { get; set; }
        public byte Messagetype { get; set; }
        public byte Messagecode { get; set; }
        public string Message { get; set; }

        public virtual Job Job { get; set; }
        public virtual Jobordbox Jobbox { get; set; }
        public virtual Jobordline Jobline { get; set; }
        public virtual Joborderrelease Jobor { get; set; }
    }
}
