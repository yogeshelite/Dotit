using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DemandReconcile
    {
        public string Company { get; set; }
        public int ReconcileNum { get; set; }
        public int DemandContractNum { get; set; }
        public int CustNum { get; set; }
        public string Ponum { get; set; }
        public string PartNum { get; set; }
        public int ShipToCustNum { get; set; }
        public string ShipToNum { get; set; }
        public decimal ShippedCummqty { get; set; }
        public decimal Tpcummqty { get; set; }
        public decimal ReconcileCummqty { get; set; }
        public DateTime? ShippedCummdate { get; set; }
        public DateTime? Tpcummdate { get; set; }
        public string DemandCharacter01 { get; set; }
        public string DemandCharacter02 { get; set; }
        public string DemandCharacter03 { get; set; }
        public string DemandCharacter04 { get; set; }
        public decimal DemandNumber01 { get; set; }
        public decimal DemandNumber02 { get; set; }
        public decimal DemandNumber03 { get; set; }
        public decimal DemandNumber04 { get; set; }
        public DateTime? DemandDate01 { get; set; }
        public DateTime? DemandDate02 { get; set; }
        public DateTime? DemandDate03 { get; set; }
        public DateTime? DemandDate04 { get; set; }
        public bool DemandLogical01 { get; set; }
        public bool DemandLogical02 { get; set; }
        public bool DemandLogical03 { get; set; }
        public bool DemandLogical04 { get; set; }
        public int TplastShipmentId { get; set; }
        public decimal TplastShipmentQty { get; set; }
        public DateTime? TplastShipmentDate { get; set; }
        public string TpscheduleNumber { get; set; }
        public int CilastShipmentId { get; set; }
        public decimal CilastShipmentQty { get; set; }
        public DateTime? CilastShipmentDate { get; set; }
        public DateTime? RestartDate { get; set; }
        public string RestartSchedNum { get; set; }
        public string RestartPonum { get; set; }
        public int TplastMasterPack { get; set; }
        public int CilastMasterPack { get; set; }
        public decimal StartCumQty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string DemandUom { get; set; }
    }
}
