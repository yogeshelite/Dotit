using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Appconfig
    {
        public int Configid { get; set; }
        public int Appid { get; set; }
        public string Configcode { get; set; }
        public string Configvalue { get; set; }
        public string Configtype { get; set; }
        public bool Isencrypted { get; set; }
        public string Configtestvalue { get; set; }
        public string Configdesc { get; set; }
        public bool? Exposeconfig { get; set; }

        public virtual Application App { get; set; }
    }
}
