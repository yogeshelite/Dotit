using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacRecImportAdj
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RecHeadId { get; set; }
        public decimal RecImportId { get; set; }
        public decimal RecImportAdjId { get; set; }
        public decimal RecDtlId { get; set; }
        public int CustNum { get; set; }
        public int ClientCustNum { get; set; }
        public string ReferenceCode { get; set; }
        public string Bcd { get; set; }
        public string BillGroupCd { get; set; }
        public string BadjRsnCd { get; set; }
        public bool Cadj { get; set; }
        public string AdjType { get; set; }
        public decimal PaidQty { get; set; }
        public decimal PaidRate { get; set; }
        public bool MissingResident { get; set; }
        public bool MissingBcd { get; set; }
        public bool GroupAdj { get; set; }
        public decimal BilledQty { get; set; }
        public decimal BilledRate { get; set; }
        public DateTime? AdjDate { get; set; }
        public decimal AdjQty { get; set; }
        public decimal AdjRate { get; set; }
        public decimal Cqty { get; set; }
        public decimal Crate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string ReasonComment { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
