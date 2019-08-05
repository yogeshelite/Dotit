using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QbuildMapping
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public string ObjName { get; set; }
        public string ObjParameter { get; set; }
        public string MappedInputName { get; set; }
        public string ObjParameterDataType { get; set; }
        public string ObjParameterInitValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual QbuildObj QbuildObj { get; set; }
    }
}
