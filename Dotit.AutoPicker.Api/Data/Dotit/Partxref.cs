using System;
using System.Collections.Generic;

namespace DotIt.AutoPickerApi.Data.DotIt
{
    public partial class Partxref
    {
        public short Pxrefid { get; set; }
        public string Outsidepartnum { get; set; }
        public string Partnum { get; set; }
        public string Shipvia { get; set; }
        public string Folder { get; set; }
    }
}
