using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartLot
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string LotNum { get; set; }
        public string PartLotDescription { get; set; }
        public bool OnHand { get; set; }
        public DateTime? FirstRefDate { get; set; }
        public DateTime? LastRefDate { get; set; }
        public decimal LotLaborCost { get; set; }
        public decimal LotBurdenCost { get; set; }
        public decimal LotMaterialCost { get; set; }
        public decimal LotSubContCost { get; set; }
        public decimal LotMtlBurCost { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool ShipDocAvail { get; set; }
        public string Batch { get; set; }
        public string MfgBatch { get; set; }
        public string MfgLot { get; set; }
        public string HeatNum { get; set; }
        public string FirmWare { get; set; }
        public DateTime? BestBeforeDt { get; set; }
        public DateTime? MfgDt { get; set; }
        public DateTime? CureDt { get; set; }
        public DateTime? ExpireDt { get; set; }
        public decimal FifolotLaborCost { get; set; }
        public decimal FifolotBurdenCost { get; set; }
        public decimal FifolotMaterialCost { get; set; }
        public decimal FifolotSubContCost { get; set; }
        public decimal FifolotMtlBurCost { get; set; }
        public string CsflmwcomOath { get; set; }
        public string Csfcj5formNbr { get; set; }
        public string Csfcj5vessel { get; set; }
        public DateTime? Csfcj5apvlStart { get; set; }
        public DateTime? Csfcj5apvlEnd { get; set; }
        public string ImportNum { get; set; }
        public int ImportedFrom { get; set; }
        public string ImportedFromDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string MximportLocation { get; set; }
        public DateTime? MximportDate { get; set; }
        public decimal TotalQtyAvg { get; set; }
    }
}
