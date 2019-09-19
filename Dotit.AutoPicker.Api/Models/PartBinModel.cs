using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Models
{
    public class PartBinModel
    {
    
        public String Company { get; set; }
        public String PartNum { get; set; }
        public String Plant { get; set; }
        public String WhseCode { get; set; }
        public String BinNum { get; set; }
        public String LotNumber { get; set; }
        public String DimCode { get; set; }
        public double QtyOnHand { get; set; }
        public String PartDesc { get; set; }
        public String PlantName { get; set; }
        public String WhseCodeDesc { get; set; }
        public String BinDesc { get; set; }
        public String LotNumberDesc { get; set; }
        public String DimCodeDesc { get; set; }
        public bool NonNettable { get; set; }
        public String IUM { get; set; }
        public String BinType { get; set; }
        public String ContractID { get; set; }
        public String PCID { get; set; }
        public bool SendToFSA { get; set; }
        public Guid SysRowID { get; set; }
        public String RowMod { get; set; }
      
    }
}
