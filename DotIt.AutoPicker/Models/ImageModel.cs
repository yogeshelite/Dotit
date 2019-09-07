using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Models
{
    public class ImageModel
    {
        public string Company { get; set; }
        public string ImageID { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContent { get; set; }
        public string ImageFileThumbnail { get; set; }
        public string ImageCategoryID { get; set; }
        public string ImageSubCategoryID { get; set; }

        public int FileSize { get; set; }

        public string FileType { get; set; }

        public string SysRevID { get; set; }
        public string SysRowID { get; set; }

        public string ImageSysRowID { get; set; }
    }
}
