using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imecslxmldtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EcsalesReportId { get; set; }
        public int LineNum { get; set; }
        public string SysEumemState { get; set; }
        public string UsrEumemState { get; set; }
        public string SysCustomerVrn { get; set; }
        public string UsrCustomerVrn { get; set; }
        public string CreateUser { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal UsrValue { get; set; }
        public decimal SysValue { get; set; }
        public int HedNum { get; set; }
        public string SysIndicator { get; set; }
        public string UsrIndicator { get; set; }
        public string SysName { get; set; }
        public string UsrName { get; set; }
        public decimal SysTaxValue { get; set; }
        public decimal UsrTaxValue { get; set; }
        public string SysModule { get; set; }
        public string UsrModule { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
