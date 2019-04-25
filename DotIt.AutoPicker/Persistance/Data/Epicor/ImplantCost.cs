using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImplantCost
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
