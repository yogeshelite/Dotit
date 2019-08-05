using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WipRpt
    {
        public string JobNum { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string PartDescription { get; set; }
        public string ProdCode { get; set; }
        public decimal ProdQty { get; set; }
        public decimal QtyShipped { get; set; }
        public decimal QtyToInventory { get; set; }
        public decimal TdlaborCost { get; set; }
        public decimal TdburdenCost { get; set; }
        public decimal TdmaterialCost { get; set; }
        public decimal TdsubcontractCost { get; set; }
        public decimal LaborCos { get; set; }
        public decimal BurdenCos { get; set; }
        public decimal MaterialCos { get; set; }
        public decimal SubContractCos { get; set; }
        public decimal LaborCti { get; set; }
        public decimal BurdenCti { get; set; }
        public decimal MaterialCti { get; set; }
        public decimal SubcontractCti { get; set; }
        public decimal CompletedQty { get; set; }
        public decimal TdmtlBurCost { get; set; }
        public decimal MtlBurCti { get; set; }
        public decimal MtlBurCos { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
