using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImidnumCnfg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FormatId { get; set; }
        public bool Active { get; set; }
        public bool AddLeadingZeroDay { get; set; }
        public bool AddLeadingZeroMonth { get; set; }
        public string ConditionalSeparator { get; set; }
        public string CountryCode { get; set; }
        public string Description { get; set; }
        public string DefaultPrefix { get; set; }
        public string FreeText1 { get; set; }
        public string FreeText2 { get; set; }
        public string Format { get; set; }
        public string GenerationType { get; set; }
        public string ManufacturerCode { get; set; }
        public int ModelYear { get; set; }
        public string NumberOption { get; set; }
        public bool PrefixIsOverrideable { get; set; }
        public string Separator { get; set; }
        public int SeqLength { get; set; }
        public int StartMonth { get; set; }
        public string YearFormat { get; set; }
        public string Idtype { get; set; }
        public string WorldManufacturerCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
