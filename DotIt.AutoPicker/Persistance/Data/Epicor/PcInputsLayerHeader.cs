using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcInputsLayerHeader
    {
        public PcInputsLayerHeader()
        {
            PcInputsLayerDetail = new HashSet<PcInputsLayerDetail>();
        }

        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public string ImageLayerId { get; set; }
        public string ImageId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string FileType { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public int Version { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PcInputs PcInputs { get; set; }
        public virtual ICollection<PcInputsLayerDetail> PcInputsLayerDetail { get; set; }
    }
}
