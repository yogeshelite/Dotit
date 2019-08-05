using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImageCategory
    {
        public ImageCategory()
        {
            ImageDefaultCategory = new HashSet<ImageDefaultCategory>();
            ImageSubCategory = new HashSet<ImageSubCategory>();
        }

        public string Company { get; set; }
        public string ImageCategoryId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int MaxSize { get; set; }

        public virtual ICollection<ImageDefaultCategory> ImageDefaultCategory { get; set; }
        public virtual ICollection<ImageSubCategory> ImageSubCategory { get; set; }
    }
}
