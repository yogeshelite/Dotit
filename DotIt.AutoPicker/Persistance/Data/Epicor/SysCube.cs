using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SysCube
    {
        public string Company { get; set; }
        public string CubeId { get; set; }
        public string Dimension1Id { get; set; }
        public string Dimension1 { get; set; }
        public string Dimension2Id { get; set; }
        public string Dimension2 { get; set; }
        public DateTime? Dimension2Date { get; set; }
        public decimal ValueDec01 { get; set; }
        public decimal ValueDec02 { get; set; }
        public decimal ValueDec03 { get; set; }
        public decimal ValueDec04 { get; set; }
        public decimal ValueDec05 { get; set; }
        public decimal ValueDec06 { get; set; }
        public decimal ValueDec07 { get; set; }
        public decimal ValueDec08 { get; set; }
        public decimal ValueDec09 { get; set; }
        public decimal ValueDec10 { get; set; }
        public int ValueInt01 { get; set; }
        public int ValueInt02 { get; set; }
        public int ValueInt03 { get; set; }
        public int ValueInt04 { get; set; }
        public int ValueInt05 { get; set; }
        public string SysCharacter01 { get; set; }
        public string SysCharacter02 { get; set; }
        public string SysCharacter03 { get; set; }
        public string SysCharacter04 { get; set; }
        public string SysCharacter05 { get; set; }
        public string SysCharacter06 { get; set; }
        public string SysCharacter07 { get; set; }
        public string SysCharacter08 { get; set; }
        public string SysCharacter09 { get; set; }
        public string SysCharacter10 { get; set; }
        public string QueryId { get; set; }
        public DateTime? RunDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
