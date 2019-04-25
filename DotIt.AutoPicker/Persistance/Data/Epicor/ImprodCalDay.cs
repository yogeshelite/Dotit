using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprodCalDay
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CalendarId { get; set; }
        public DateTime? ModifiedDay { get; set; }
        public bool ProdHour01 { get; set; }
        public bool ProdHour02 { get; set; }
        public bool ProdHour03 { get; set; }
        public bool ProdHour04 { get; set; }
        public bool ProdHour05 { get; set; }
        public bool ProdHour06 { get; set; }
        public bool ProdHour07 { get; set; }
        public bool ProdHour08 { get; set; }
        public bool ProdHour09 { get; set; }
        public bool ProdHour10 { get; set; }
        public bool ProdHour11 { get; set; }
        public bool ProdHour12 { get; set; }
        public bool ProdHour13 { get; set; }
        public bool ProdHour14 { get; set; }
        public bool ProdHour15 { get; set; }
        public bool ProdHour16 { get; set; }
        public bool ProdHour17 { get; set; }
        public bool ProdHour18 { get; set; }
        public bool ProdHour19 { get; set; }
        public bool ProdHour20 { get; set; }
        public bool ProdHour21 { get; set; }
        public bool ProdHour22 { get; set; }
        public bool ProdHour23 { get; set; }
        public bool ProdHour24 { get; set; }
        public bool WorkingDay { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ExceptionLabel { get; set; }
    }
}
