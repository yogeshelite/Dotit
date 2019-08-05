using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsPressfweblyt
    {
        public EsPressfweblyt()
        {
            EsPresselg = new HashSet<EsPresselg>();
            EsPressfwebform = new HashSet<EsPressfwebform>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string PressFwebLytUserId { get; set; }
        public string PressFwebFpsizeId { get; set; }
        public string PressId { get; set; }
        public string PressFwebFpsizeUserId { get; set; }
        public int Priority { get; set; }
        public int PgCount { get; set; }
        public int NumOutW { get; set; }
        public int NumOutL { get; set; }
        public int? SignaturesOut { get; set; }
        public decimal MinCaliper { get; set; }
        public decimal MaxCaliper { get; set; }
        public string PageOrientation { get; set; }
        public int SetupShtPerLyt { get; set; }
        public decimal SetupHrsPerLyt { get; set; }
        public decimal? ProdSpoilPct { get; set; }
        public decimal? ProdLaborPct { get; set; }
        public decimal ProdSpoilPctUi { get; set; }
        public decimal ProdLaborPctUi { get; set; }
        public string GroupId { get; set; }
        public string TopLevelUserId { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string PressUserId { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public string UserChar5 { get; set; }
        public string UserChar6 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public DateTime? UserDate5 { get; set; }
        public DateTime? UserDate6 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public decimal? UserDecimal9 { get; set; }
        public decimal? UserDecimal10 { get; set; }
        public decimal? UserDecimal11 { get; set; }
        public decimal? UserDecimal12 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }
        public int? UserInteger5 { get; set; }
        public int? UserInteger6 { get; set; }

        public virtual EsPressfwebfpsize PressFwebFpsize { get; set; }
        public virtual ICollection<EsPresselg> EsPresselg { get; set; }
        public virtual ICollection<EsPressfwebform> EsPressfwebform { get; set; }
    }
}
