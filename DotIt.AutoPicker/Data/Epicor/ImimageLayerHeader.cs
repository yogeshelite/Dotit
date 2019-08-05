using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImimageLayerHeader
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
