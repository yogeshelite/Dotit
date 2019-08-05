using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EftpropVal
    {
        public int EftheadUid { get; set; }
        public int EftpropUid { get; set; }
        public int EftpropValUid { get; set; }
        public string PropValue { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
