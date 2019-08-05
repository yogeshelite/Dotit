using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PlantCost
    {
        public string Company { get; set; }
        public string PlantCostId { get; set; }
        public string Description { get; set; }
        public string PrimaryPlant { get; set; }
        public bool LoadAltMethod { get; set; }
        public bool LoadCostLot { get; set; }
        public bool EnableFifolayers { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SkipRevCostRollup { get; set; }
        public bool FifoupdateIssuedCost { get; set; }
    }
}
