using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ecslxmldtl
    {
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
