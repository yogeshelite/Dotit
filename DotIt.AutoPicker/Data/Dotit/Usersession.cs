using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Usersession
    {
        public string Sessionguid { get; set; }
        public int Userid { get; set; }
        public int Partnerid { get; set; }
        public DateTime Sessiondate { get; set; }
        public int Sessionvalidduration { get; set; }
        public bool Testing { get; set; }
        public bool Expired { get; set; }
        public string Callingipaddr { get; set; }
        public DateTime Sessionexpiredate { get; set; }
        public bool Islongtermtoken { get; set; }

        public virtual Accountuser User { get; set; }
    }
}
