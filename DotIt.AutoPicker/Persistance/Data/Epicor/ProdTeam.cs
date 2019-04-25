using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProdTeam
    {
        public string Company { get; set; }
        public string ProdTeamId { get; set; }
        public string Description { get; set; }
        public string PersonList { get; set; }
        public string Name { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
