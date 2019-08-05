using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Issyst
    {
        public string Company { get; set; }
        public bool EnableHarbour { get; set; }
        public string PeriodFormat { get; set; }
        public string DescType { get; set; }
        public string DefIsregion { get; set; }
        public bool IsorigCountryReq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Aprgflow2 { get; set; }
        public string AprgflowSpec2 { get; set; }
        public string AprgtranType2 { get; set; }
        public string Arrgflow2 { get; set; }
        public string ArrgflowSpec2 { get; set; }
        public string ArrgtranType2 { get; set; }
        public bool Generate2Aprgline { get; set; }
        public bool Generate2Arrgline { get; set; }
        public string Flow1Desc { get; set; }
        public string Flow2Desc { get; set; }
        public int StartIstatNum { get; set; }
        public string Apflow { get; set; }
        public string ApflowSpec { get; set; }
        public string AptranType { get; set; }
        public string Aprgflow { get; set; }
        public string AprgflowSpec { get; set; }
        public string AprgtranType { get; set; }
        public string Arflow { get; set; }
        public string ArflowSpec { get; set; }
        public string ArtranType { get; set; }
        public string Arrgflow { get; set; }
        public string ArrgflowSpec { get; set; }
        public string ArrgtranType { get; set; }
        public string Iscurrency { get; set; }
    }
}
