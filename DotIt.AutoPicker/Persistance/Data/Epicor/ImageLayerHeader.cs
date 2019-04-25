using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImageLayerHeader
    {
        public ImageLayerHeader()
        {
            ImageLayerDetail = new HashSet<ImageLayerDetail>();
        }

        public string Company { get; set; }
        public string ImageLayerId { get; set; }
        public string ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string FileType { get; set; }
        public string Description { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public bool Approved { get; set; }
        public int Version { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<ImageLayerDetail> ImageLayerDetail { get; set; }
    }
}
