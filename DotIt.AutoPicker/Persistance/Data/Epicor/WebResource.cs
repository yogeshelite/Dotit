using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WebResource
    {
        public WebResource()
        {
            WebPersonalization = new HashSet<WebPersonalization>();
        }

        public string WebResourceId { get; set; }
        public string SystemCode { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Metadata { get; set; }
        public string RequiredModules { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<WebPersonalization> WebPersonalization { get; set; }
    }
}
